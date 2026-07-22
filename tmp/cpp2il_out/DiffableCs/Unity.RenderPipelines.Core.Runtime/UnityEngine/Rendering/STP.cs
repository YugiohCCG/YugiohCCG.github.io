namespace UnityEngine.Rendering;

public static class STP
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<SetupData, ComputeGraphContext> <>9__38_0; //Field offset: 0x8
		public static BaseRenderFunc<PreTaaData, ComputeGraphContext> <>9__38_1; //Field offset: 0x10
		public static BaseRenderFunc<TaaData, ComputeGraphContext> <>9__38_2; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConstantBuffer), Member = "UpdateData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.STP+StpConstantBufferData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(StpConstantBufferData&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ConstantBuffer), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.STP+StpConstantBufferData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ComputeCommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), typeof(TextureHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ComputeCommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), typeof(TextureHandle), typeof(int), typeof(RenderTextureSubElement)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal void <Execute>b__38_0(SetupData data, ComputeGraphContext ctx) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConstantBuffer), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.STP+StpConstantBufferData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ComputeCommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), typeof(TextureHandle)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <Execute>b__38_1(PreTaaData data, ComputeGraphContext ctx) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConstantBuffer), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.STP+StpConstantBufferData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ComputeCommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), typeof(TextureHandle)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <Execute>b__38_2(TaaData data, ComputeGraphContext ctx) { }

	}

	internal struct Config
	{
		public Texture2D noiseTexture; //Field offset: 0x0
		public TextureHandle inputColor; //Field offset: 0x8
		public TextureHandle inputDepth; //Field offset: 0x18
		public TextureHandle inputMotion; //Field offset: 0x28
		public TextureHandle inputStencil; //Field offset: 0x38
		public TextureHandle debugView; //Field offset: 0x48
		public TextureHandle destination; //Field offset: 0x58
		public HistoryContext historyContext; //Field offset: 0x68
		public bool enableHwDrs; //Field offset: 0x70
		public bool enableTexArray; //Field offset: 0x71
		public bool enableMotionScaling; //Field offset: 0x72
		public float nearPlane; //Field offset: 0x74
		public float farPlane; //Field offset: 0x78
		public int frameIndex; //Field offset: 0x7C
		public bool hasValidHistory; //Field offset: 0x80
		public int stencilMask; //Field offset: 0x84
		public int debugViewIndex; //Field offset: 0x88
		public float deltaTime; //Field offset: 0x8C
		public float lastDeltaTime; //Field offset: 0x90
		public Vector2Int currentImageSize; //Field offset: 0x94
		public Vector2Int priorImageSize; //Field offset: 0x9C
		public Vector2Int outputImageSize; //Field offset: 0xA4
		public int numActiveViews; //Field offset: 0xAC
		public PerViewConfig[] perViewConfigs; //Field offset: 0xB0

	}

	internal sealed class HistoryContext : IDisposable
	{
		private RTHandle[] m_textures; //Field offset: 0x10
		private Hash128 m_hash; //Field offset: 0x18

		[CalledBy(Type = "UnityEngine.Rendering.Universal.StpHistory", Member = "OnCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferedRTHandleSystem), typeof(uint)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Hash128), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Hash128))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public HistoryContext() { }

		[CalledBy(Type = "UnityEngine.Rendering.Universal.StpHistory", Member = "Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
		[Calls(Type = typeof(Hash128), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Hash128))]
		[CallsUnknownMethods(Count = 3)]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal RTHandle GetCurrentHistoryTexture(HistoryTextureType historyType, int frameIndex) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal RTHandle GetPreviousHistoryTexture(HistoryTextureType historyType, int frameIndex) { }

		[CalledBy(Type = "UnityEngine.Rendering.Universal.StpHistory", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Hash128), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hash128), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hash128), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(Hash128)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
		[Calls(Type = typeof(Hash128), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Hash128))]
		[Calls(Type = typeof(STP), Member = "CalculateConvergenceTextureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int)}, ReturnType = typeof(Vector2Int))]
		[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
		[CallsUnknownMethods(Count = 7)]
		public bool Update(ref HistoryUpdateInfo info) { }

	}

	public enum HistoryTextureType
	{
		DepthMotion = 0,
		Luma = 1,
		Convergence = 2,
		Feedback = 3,
		Count = 4,
	}

	internal struct HistoryUpdateInfo
	{
		public Vector2Int preUpscaleSize; //Field offset: 0x0
		public Vector2Int postUpscaleSize; //Field offset: 0x8
		public bool useHwDrs; //Field offset: 0x10
		public bool useTexArray; //Field offset: 0x11

	}

	internal struct PerViewConfig
	{
		public Matrix4x4 currentProj; //Field offset: 0x0
		public Matrix4x4 lastProj; //Field offset: 0x40
		public Matrix4x4 lastLastProj; //Field offset: 0x80
		public Matrix4x4 currentView; //Field offset: 0xC0
		public Matrix4x4 lastView; //Field offset: 0x100
		public Matrix4x4 lastLastView; //Field offset: 0x140

	}

	private class PreTaaData
	{
		public ComputeShader cs; //Field offset: 0x10
		public int kernelIndex; //Field offset: 0x18
		public int viewCount; //Field offset: 0x1C
		public Vector2Int dispatchSize; //Field offset: 0x20
		public TextureHandle noiseTexture; //Field offset: 0x28
		public TextureHandle debugView; //Field offset: 0x38
		public TextureHandle intermediateConvergence; //Field offset: 0x48
		public TextureHandle intermediateWeights; //Field offset: 0x58
		public TextureHandle luma; //Field offset: 0x68
		public TextureHandle convergence; //Field offset: 0x78

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PreTaaData() { }

	}

	private enum ProfileId
	{
		StpSetup = 0,
		StpPreTaa = 1,
		StpTaa = 2,
	}

	[CategoryInfo(Name = "R: STP", Order = 1000)]
	[ElementInfo(Order = 0)]
	[HideInInspector]
	[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
	public class RuntimeResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[ResourcePath("Runtime/STP/StpSetup.compute", SearchType::ProjectPath (0))]
		[SerializeField]
		private ComputeShader m_setupCS; //Field offset: 0x10
		[ResourcePath("Runtime/STP/StpPreTaa.compute", SearchType::ProjectPath (0))]
		[SerializeField]
		private ComputeShader m_preTaaCS; //Field offset: 0x18
		[ResourcePath("Runtime/STP/StpTaa.compute", SearchType::ProjectPath (0))]
		[SerializeField]
		private ComputeShader m_taaCS; //Field offset: 0x20

		public ComputeShader preTaaCS
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
			 set { } //Length: 101
		}

		public ComputeShader setupCS
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
			 set { } //Length: 101
		}

		public ComputeShader taaCS
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
			 set { } //Length: 101
		}

		public override int version
		{
			[CallerCount(Count = 182)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public RuntimeResources() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public ComputeShader get_preTaaCS() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public ComputeShader get_setupCS() { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public ComputeShader get_taaCS() { }

		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		public override int get_version() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		public void set_preTaaCS(ComputeShader value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		public void set_setupCS(ComputeShader value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		public void set_taaCS(ComputeShader value) { }

	}

	private class SetupData
	{
		public ComputeShader cs; //Field offset: 0x10
		public int kernelIndex; //Field offset: 0x18
		public int viewCount; //Field offset: 0x1C
		public Vector2Int dispatchSize; //Field offset: 0x20
		public StpConstantBufferData constantBufferData; //Field offset: 0x28
		public TextureHandle noiseTexture; //Field offset: 0x1E8
		public TextureHandle debugView; //Field offset: 0x1F8
		public TextureHandle inputColor; //Field offset: 0x208
		public TextureHandle inputDepth; //Field offset: 0x218
		public TextureHandle inputMotion; //Field offset: 0x228
		public TextureHandle inputStencil; //Field offset: 0x238
		public TextureHandle intermediateColor; //Field offset: 0x248
		public TextureHandle intermediateConvergence; //Field offset: 0x258
		public TextureHandle priorDepthMotion; //Field offset: 0x268
		public TextureHandle depthMotion; //Field offset: 0x278
		public TextureHandle priorLuma; //Field offset: 0x288
		public TextureHandle luma; //Field offset: 0x298
		public TextureHandle priorFeedback; //Field offset: 0x2A8
		public TextureHandle priorConvergence; //Field offset: 0x2B8

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SetupData() { }

	}

	private static class ShaderKeywords
	{
		public static readonly string EnableDebugMode; //Field offset: 0x0
		public static readonly string EnableLargeKernel; //Field offset: 0x8
		public static readonly string EnableStencilResponsive; //Field offset: 0x10
		public static readonly string DisableTexture2DXArray; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		private static ShaderKeywords() { }

	}

	private static class ShaderResources
	{
		public static readonly int _StpConstantBufferData; //Field offset: 0x0
		public static readonly int _StpBlueNoiseIn; //Field offset: 0x4
		public static readonly int _StpDebugOut; //Field offset: 0x8
		public static readonly int _StpInputColor; //Field offset: 0xC
		public static readonly int _StpInputDepth; //Field offset: 0x10
		public static readonly int _StpInputMotion; //Field offset: 0x14
		public static readonly int _StpInputStencil; //Field offset: 0x18
		public static readonly int _StpIntermediateColor; //Field offset: 0x1C
		public static readonly int _StpIntermediateConvergence; //Field offset: 0x20
		public static readonly int _StpIntermediateWeights; //Field offset: 0x24
		public static readonly int _StpPriorLuma; //Field offset: 0x28
		public static readonly int _StpLuma; //Field offset: 0x2C
		public static readonly int _StpPriorDepthMotion; //Field offset: 0x30
		public static readonly int _StpDepthMotion; //Field offset: 0x34
		public static readonly int _StpPriorFeedback; //Field offset: 0x38
		public static readonly int _StpFeedback; //Field offset: 0x3C
		public static readonly int _StpPriorConvergence; //Field offset: 0x40
		public static readonly int _StpConvergence; //Field offset: 0x44
		public static readonly int _StpOutput; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderResources() { }

	}

	[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@ae070e0972dd\\Runtime\\STP\\STP.cs", needAccessors = False, generateCBuffer = True)]
	private struct StpConstantBufferData
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <_StpSetupPerViewConstants>e__FixedBuffer
		{
			public float FixedElementField; //Field offset: 0x0

		}

		public Vector4 _StpCommonConstant; //Field offset: 0x0
		public Vector4 _StpSetupConstants0; //Field offset: 0x10
		public Vector4 _StpSetupConstants1; //Field offset: 0x20
		public Vector4 _StpSetupConstants2; //Field offset: 0x30
		public Vector4 _StpSetupConstants3; //Field offset: 0x40
		public Vector4 _StpSetupConstants4; //Field offset: 0x50
		public Vector4 _StpSetupConstants5; //Field offset: 0x60
		[FixedBuffer(typeof(float), 64)]
		[HLSLArray(16, typeof(Vector4))]
		public <_StpSetupPerViewConstants>e__FixedBuffer _StpSetupPerViewConstants; //Field offset: 0x70
		public Vector4 _StpDilConstants0; //Field offset: 0x170
		public Vector4 _StpTaaConstants0; //Field offset: 0x180
		public Vector4 _StpTaaConstants1; //Field offset: 0x190
		public Vector4 _StpTaaConstants2; //Field offset: 0x1A0
		public Vector4 _StpTaaConstants3; //Field offset: 0x1B0

	}

	[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@ae070e0972dd\\Runtime\\STP\\STP.cs")]
	private enum StpSetupPerViewConstants
	{
		Count = 8,
	}

	private class TaaData
	{
		public ComputeShader cs; //Field offset: 0x10
		public int kernelIndex; //Field offset: 0x18
		public int viewCount; //Field offset: 0x1C
		public Vector2Int dispatchSize; //Field offset: 0x20
		public TextureHandle noiseTexture; //Field offset: 0x28
		public TextureHandle debugView; //Field offset: 0x38
		public TextureHandle intermediateColor; //Field offset: 0x48
		public TextureHandle intermediateWeights; //Field offset: 0x58
		public TextureHandle priorFeedback; //Field offset: 0x68
		public TextureHandle depthMotion; //Field offset: 0x78
		public TextureHandle convergence; //Field offset: 0x88
		public TextureHandle feedback; //Field offset: 0x98
		public TextureHandle output; //Field offset: 0xA8

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public TaaData() { }

	}

	private const int kNumDebugViews = 6; //Field offset: 0x0
	private static readonly GUIContent[] s_DebugViewDescriptions; //Field offset: 0x0
	private const int kMaxPerViewConfigs = 2; //Field offset: 0x0
	private const int kNumHistoryTextureTypes = 4; //Field offset: 0x0
	private const int kTotalSetupViewConstantsCount = 16; //Field offset: 0x0
	private static readonly Int32[] s_DebugViewIndices; //Field offset: 0x8
	private static PerViewConfig[] s_PerViewConfigs; //Field offset: 0x10
	private static readonly int kQualcommVendorId; //Field offset: 0x18

	public static GUIContent[] debugViewDescriptions
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	public static Int32[] debugViewIndices
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static PerViewConfig[] perViewConfigs
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 110
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 29)]
	private static STP() { }

	[CalledBy(Type = typeof(HistoryContext), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HistoryUpdateInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(STP), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Config&)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static Vector2Int CalculateConvergenceTextureSize(Vector2Int historyTextureSize) { }

	[CallerCount(Count = 0)]
	private static float CalculateMotionScale(float deltaTime, float lastDeltaTime) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash128), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hash128), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int&)}, ReturnType = typeof(void))]
	private static Hash128 ComputeHistoryHash(ref HistoryUpdateInfo info) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.StpUtils", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalResourceData", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(STP), Member = "CalculateConvergenceTextureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(STP), Member = "PopulateConstantData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config&), typeof(StpConstantBufferData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "AddComputePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IComputeRenderGraphBuilder))]
	[Calls(Type = typeof(RenderTexture), Member = "ApplyDynamicScale", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RenderTargetInfo), typeof(ImportResourceParams)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RTHandleStaticHelpers), Member = "SetRTHandleStaticWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 51)]
	[CallsUnknownMethods(Count = 169)]
	public static TextureHandle Execute(RenderGraph renderGraph, ref Config config) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	private static Matrix4x4 ExtractRotation(Matrix4x4 input) { }

	[CallerCount(Count = 0)]
	public static GUIContent[] get_debugViewDescriptions() { }

	[CallerCount(Count = 0)]
	public static Int32[] get_debugViewIndices() { }

	[CallerCount(Count = 0)]
	public static PerViewConfig[] get_perViewConfigs() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "ResolveUpscalingFilterSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), "UnityEngine.Rendering.Universal.UpscalingFilterSelection", typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.ImageUpscalingFilter")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool IsSupported() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.StpUtils", Member = "CalculateJitter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HaltonSequence), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	public static Vector2 Jit16(int frameIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	private static int PackVector2ToInt(Vector2 value) { }

	[CalledBy(Type = typeof(STP), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Config&)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HaltonSequence), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	private static void PopulateConstantData(ref Config config, ref StpConstantBufferData constants) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void set_perViewConfigs(PerViewConfig[] value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static TextureHandle UseTexture(IBaseRenderGraphBuilder builder, TextureHandle texture, AccessFlags flags = 1) { }

}

