namespace UnityEngine.Rendering.Universal;

public static class TemporalAA
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<TaaPassData, RasterGraphContext> <>9__17_0; //Field offset: 0x8
		public static BaseRenderFunc<TaaPassData, RasterGraphContext> <>9__17_1; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(Texture))]
		[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "SetFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		internal void <Render>b__17_0(TaaPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <Render>b__17_1(TaaPassData data, RasterGraphContext context) { }

	}

	public sealed class JitterFunc : MulticastDelegate
	{

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public JitterFunc(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(int frameIndex, out Vector2 jitter, out bool allowScaling, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(out Vector2 jitter, out bool allowScaling, IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(int frameIndex, out Vector2 jitter, out bool allowScaling) { }

	}

	internal struct Settings
	{
		[FormerlySerializedAs("quality")]
		[SerializeField]
		internal TemporalAAQuality m_Quality; //Field offset: 0x0
		[FormerlySerializedAs("frameInfluence")]
		[SerializeField]
		internal float m_FrameInfluence; //Field offset: 0x4
		[FormerlySerializedAs("jitterScale")]
		[SerializeField]
		internal float m_JitterScale; //Field offset: 0x8
		[FormerlySerializedAs("mipBias")]
		[SerializeField]
		internal float m_MipBias; //Field offset: 0xC
		[FormerlySerializedAs("varianceClampScale")]
		[SerializeField]
		internal float m_VarianceClampScale; //Field offset: 0x10
		[FormerlySerializedAs("contrastAdaptiveSharpening")]
		[SerializeField]
		internal float m_ContrastAdaptiveSharpening; //Field offset: 0x14
		internal int resetHistoryFrames; //Field offset: 0x18
		internal int jitterFrameCountOffset; //Field offset: 0x1C

		public float baseBlendFactor
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 14
			[CallerCount(Count = 0)]
			 set { } //Length: 46
		}

		public float contrastAdaptiveSharpening
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			 set { } //Length: 33
		}

		public float jitterScale
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "ApplyTaaRenderingDebugOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Settings&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			 set { } //Length: 33
		}

		public float mipBias
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			 set { } //Length: 36
		}

		public TemporalAAQuality quality
		{
			[CallerCount(Count = 173)]
			[DeduplicatedMethod]
			 get { } //Length: 3
			[CallerCount(Count = 0)]
			 set { } //Length: 22
		}

		public float varianceClampScale
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			 set { } //Length: 41
		}

		[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public static Settings Create() { }

		[CallerCount(Count = 0)]
		public float get_baseBlendFactor() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public float get_contrastAdaptiveSharpening() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public float get_jitterScale() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public float get_mipBias() { }

		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		public TemporalAAQuality get_quality() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public float get_varianceClampScale() { }

		[CallerCount(Count = 0)]
		public void set_baseBlendFactor(float value) { }

		[CallerCount(Count = 0)]
		public void set_contrastAdaptiveSharpening(float value) { }

		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "ApplyTaaRenderingDebugOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Settings&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		public void set_jitterScale(float value) { }

		[CallerCount(Count = 0)]
		public void set_mipBias(float value) { }

		[CallerCount(Count = 0)]
		public void set_quality(TemporalAAQuality value) { }

		[CallerCount(Count = 0)]
		public void set_varianceClampScale(float value) { }

	}

	public static class ShaderConstants
	{
		public static readonly int _TaaAccumulationTex; //Field offset: 0x0
		public static readonly int _TaaMotionVectorTex; //Field offset: 0x4
		public static readonly int _TaaFilterWeights; //Field offset: 0x8
		public static readonly int _TaaFrameInfluence; //Field offset: 0xC
		public static readonly int _TaaVarianceClampScale; //Field offset: 0x10
		public static readonly int _CameraDepthTexture; //Field offset: 0x14

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderConstants() { }

	}

	public static class ShaderKeywords
	{
		public static readonly string TAA_LOW_PRECISION_SOURCE; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private static ShaderKeywords() { }

	}

	private class TaaPassData
	{
		internal TextureHandle dstTex; //Field offset: 0x10
		internal TextureHandle srcColorTex; //Field offset: 0x20
		internal TextureHandle srcDepthTex; //Field offset: 0x30
		internal TextureHandle srcMotionVectorTex; //Field offset: 0x40
		internal TextureHandle srcTaaAccumTex; //Field offset: 0x50
		internal Material material; //Field offset: 0x60
		internal int passIndex; //Field offset: 0x68
		internal float taaFrameInfluence; //Field offset: 0x6C
		internal float taaVarianceClampScale; //Field offset: 0x70
		internal Single[] taaFilterWeights; //Field offset: 0x78
		internal bool taaLowPrecisionSource; //Field offset: 0x80
		internal bool taaAlphaOutput; //Field offset: 0x81

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public TaaPassData() { }

	}

	internal static JitterFunc s_JitterFunc; //Field offset: 0x0
	private static readonly Vector2[] taaFilterOffsets; //Field offset: 0x8
	private static readonly Single[] taaFilterWeights; //Field offset: 0x10
	internal static GraphicsFormat[] AccumulationFormatList; //Field offset: 0x18
	private static uint s_warnCounter; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private static TemporalAA() { }

	[CalledBy(Type = typeof(TemporalAA), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(CameraData&), typeof(RTHandle), typeof(RTHandle), typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemporalAA), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Material), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(HaltonSequence), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 3)]
	internal static Single[] CalculateFilterWeights(ref Settings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HaltonSequence), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	internal static void CalculateJitter(int frameIndex, out Vector2 jitter, out bool allowScaling) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Matrix4x4), Member = "Translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static Matrix4x4 CalculateJitterMatrix(UniversalCameraData cameraData, JitterFunc jitterFunc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	internal static int CalculateTaaFrameIndex(ref Settings settings) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TemporalAA), Member = "CalculateFilterWeights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Settings&)}, ReturnType = typeof(Single[]))]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraData), Member = "get_isAlphaOutputEnabled", ReturnType = typeof(Boolean&))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Material), Member = "SetFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraData), Member = "get_taaSettings", ReturnType = typeof(Settings&))]
	[Calls(Type = typeof(Shader), Member = "get_passCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Texture2D), Member = "get_blackTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(TaaHistory), Member = "GetAccumulationTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TaaHistory), Member = "GetAccumulationVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CameraData), Member = "get_taaHistory", ReturnType = typeof(TaaHistory&))]
	[Calls(Type = typeof(CameraData), Member = "get_xr", ReturnType = typeof(XRPass))]
	[Calls(Type = typeof(TaaHistory), Member = "SetAccumulationVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	internal static void ExecutePass(CommandBuffer cmd, Material taaMaterial, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderTexture motionVectors) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderTemporalAA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TaaHistory), Member = "GetAccumulationVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TaaHistory), Member = "GetAccumulationTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(TemporalAA), Member = "CalculateFilterWeights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Settings&)}, ReturnType = typeof(Single[]))]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Shader), Member = "get_passCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TaaHistory), Member = "SetAccumulationVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 51)]
	internal static void Render(RenderGraph renderGraph, Material taaMaterial, UniversalCameraData cameraData, ref TextureHandle srcColor, ref TextureHandle srcDepth, ref TextureHandle srcMotionVectors, ref TextureHandle dstColor) { }

	[CalledBy(Type = typeof(TaaHistory), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_enableRandomWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_bindMS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useDynamicScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static RenderTextureDescriptor TemporalAADescFromCameraDesc(ref RenderTextureDescriptor cameraDesc) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_cameraStack", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Camera>))]
	[Calls(Type = typeof(Camera), Member = "get_allowDynamicResolution", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static string ValidateAndWarn(UniversalCameraData cameraData, bool isSTPRequested = false) { }

}

