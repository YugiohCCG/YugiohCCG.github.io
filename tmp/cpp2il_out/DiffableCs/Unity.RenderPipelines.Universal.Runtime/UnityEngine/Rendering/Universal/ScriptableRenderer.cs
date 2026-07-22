namespace UnityEngine.Rendering.Universal;

public abstract class ScriptableRenderer : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, UnsafeGraphContext> <>9__140_0; //Field offset: 0x8
		public static BaseRenderFunc<VFXProcessCameraPassData, UnsafeGraphContext> <>9__142_0; //Field offset: 0x10
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__143_0; //Field offset: 0x18
		public static BaseRenderFunc<BeginXRPassData, RasterGraphContext> <>9__149_0; //Field offset: 0x20
		public static BaseRenderFunc<EndXRPassData, RasterGraphContext> <>9__151_0; //Field offset: 0x28
		public static BaseRenderFunc<DummyData, UnsafeGraphContext> <>9__153_0; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(UniversalCameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
		[Calls(Type = typeof(XRPass), Member = "StartSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRasterCommandBuffer)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XRPass), Member = "get_supportsFoveatedRendering", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal void <BeginRenderGraphXRRendering>b__149_0(BeginXRPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRPass), Member = "StopSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseCommandBuffer)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal void <EndRenderGraphXRRendering>b__151_0(EndXRPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(Time), Member = "get_smoothDeltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScriptableRenderer), Member = "ClearRenderingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseCommandBuffer)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScriptableRenderer), Member = "SetShaderTimeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseCommandBuffer), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <InitRenderGraphFrame>b__140_0(PassData data, UnsafeGraphContext rgContext) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRPass), Member = "StartSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRasterCommandBuffer)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CommandBufferHelpers), Member = "VFXManager_ProcessCameraCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UnsafeCommandBuffer), typeof(VFXCameraXRSettings), typeof(CullingResults)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XRPass), Member = "StopSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseCommandBuffer)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <ProcessVFXCameraCommand>b__142_0(VFXProcessCameraPassData data, UnsafeGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
		[Calls(Type = typeof(UnsafeCommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <SetEditorTarget>b__153_0(DummyData data, UnsafeGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScriptableRenderer), Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScriptableRenderer), Member = "SetPerCameraClippingPlaneProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData&), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScriptableRenderer), Member = "SetPerCameraBillboardProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(Time), Member = "get_smoothDeltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScriptableRenderer), Member = "SetShaderTimeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseCommandBuffer), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal void <SetupRenderGraphCameraProperties>b__143_0(PassData data, RasterGraphContext context) { }

	}

	private class BeginXRPassData
	{
		internal UniversalCameraData cameraData; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public BeginXRPassData() { }

	}

	private class DrawGizmosPassData
	{
		public RendererListHandle gizmoRenderList; //Field offset: 0x10
		public TextureHandle color; //Field offset: 0x1C
		public TextureHandle depth; //Field offset: 0x2C

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DrawGizmosPassData() { }

	}

	private class DrawWireOverlayPassData
	{
		public RendererListHandle wireOverlayList; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DrawWireOverlayPassData() { }

	}

	private class DummyData
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DummyData() { }

	}

	private class EndXRPassData
	{
		public UniversalCameraData cameraData; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public EndXRPassData() { }

	}

	private class PassData
	{
		internal ScriptableRenderer renderer; //Field offset: 0x10
		internal UniversalCameraData cameraData; //Field offset: 0x18
		internal bool isTargetBackbuffer; //Field offset: 0x20
		internal Vector2Int cameraTargetSizeCopy; //Field offset: 0x24

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PassData() { }

	}

	private static class Profiling
	{
		internal static class RenderBlock
		{
			private const string k_Name = "RenderPassBlock"; //Field offset: 0x0
			public static readonly ProfilingSampler beforeRendering; //Field offset: 0x0
			public static readonly ProfilingSampler mainRenderingOpaque; //Field offset: 0x8
			public static readonly ProfilingSampler mainRenderingTransparent; //Field offset: 0x10
			public static readonly ProfilingSampler afterRendering; //Field offset: 0x18

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			private static RenderBlock() { }

		}

		internal static class RenderPass
		{
			private const string k_Name = "ScriptableRenderPass"; //Field offset: 0x0
			public static readonly ProfilingSampler configure; //Field offset: 0x0
			public static readonly ProfilingSampler setRenderPassAttachments; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 2)]
			private static RenderPass() { }

		}

		public static readonly ProfilingSampler setMRTAttachmentsList; //Field offset: 0x0
		private const string k_Name = "ScriptableRenderer"; //Field offset: 0x0
		public static readonly ProfilingSampler setAttachmentList; //Field offset: 0x8
		public static readonly ProfilingSampler execute; //Field offset: 0x10
		public static readonly ProfilingSampler setupFrameData; //Field offset: 0x18
		public static readonly ProfilingSampler setPerCameraShaderVariables; //Field offset: 0x20
		public static readonly ProfilingSampler sortRenderPasses; //Field offset: 0x28
		public static readonly ProfilingSampler recordRenderGraph; //Field offset: 0x30
		public static readonly ProfilingSampler setupLights; //Field offset: 0x38
		public static readonly ProfilingSampler setupCamera; //Field offset: 0x40
		public static readonly ProfilingSampler vfxProcessCamera; //Field offset: 0x48
		public static readonly ProfilingSampler addRenderPasses; //Field offset: 0x50
		public static readonly ProfilingSampler setupRenderPasses; //Field offset: 0x58
		public static readonly ProfilingSampler clearRenderingState; //Field offset: 0x60
		public static readonly ProfilingSampler internalStartRendering; //Field offset: 0x68
		public static readonly ProfilingSampler internalFinishRenderingCommon; //Field offset: 0x70
		public static readonly ProfilingSampler drawGizmos; //Field offset: 0x78
		public static readonly ProfilingSampler drawWireOverlay; //Field offset: 0x80
		internal static readonly ProfilingSampler beginXRRendering; //Field offset: 0x88
		internal static readonly ProfilingSampler endXRRendering; //Field offset: 0x90
		internal static readonly ProfilingSampler initRenderGraphFrame; //Field offset: 0x98
		internal static readonly ProfilingSampler setEditorTarget; //Field offset: 0xA0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 21)]
		private static Profiling() { }

	}

	public struct RenderBlocks : IDisposable
	{
		internal struct BlockRange : IDisposable
		{
			private int m_Current; //Field offset: 0x0
			private int m_End; //Field offset: 0x4

			public int Current
			{
				[CallerCount(Count = 173)]
				[DeduplicatedMethod]
				 get { } //Length: 3
			}

			[CallerCount(Count = 0)]
			public BlockRange(int begin, int end) { }

			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			public override void Dispose() { }

			[CallerCount(Count = 173)]
			[DeduplicatedMethod]
			public int get_Current() { }

			[CallerCount(Count = 138)]
			[DeduplicatedMethod]
			public BlockRange GetEnumerator() { }

			[CalledBy(Type = typeof(ScriptableRenderer), Member = "ExecuteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderBlocks&), typeof(ScriptableRenderContext), typeof(RenderingData&), typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			public bool MoveNext() { }

		}

		private NativeArray<RenderPassEvent> m_BlockEventLimits; //Field offset: 0x0
		private NativeArray<Int32> m_BlockRanges; //Field offset: 0x10
		private NativeArray<Int32> m_BlockRangeLengths; //Field offset: 0x20

		[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public RenderBlocks(List<ScriptableRenderPass> activeRenderPassQueue) { }

		[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void FillBlockRanges(List<ScriptableRenderPass> activeRenderPassQueue) { }

		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		public int GetLength(int index) { }

		[CalledBy(Type = typeof(ScriptableRenderer), Member = "ExecuteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderBlocks&), typeof(ScriptableRenderContext), typeof(RenderingData&), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public BlockRange GetRange(int index) { }

	}

	internal class RenderingFeatures
	{
		[CompilerGenerated]
		private bool <cameraStacking>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private bool <msaa>k__BackingField; //Field offset: 0x11

		[Obsolete("cameraStacking has been deprecated use SupportedCameraRenderTypes() in ScriptableRenderer instead.", True)]
		public bool cameraStacking
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
			[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 370
		}

		public bool msaa
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

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public RenderingFeatures() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public bool get_cameraStacking() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public bool get_msaa() { }

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_cameraStacking(bool value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_msaa(bool value) { }

	}

	private static class RenderPassBlock
	{
		public static readonly int BeforeRendering; //Field offset: 0x0
		public static readonly int MainRenderingOpaque; //Field offset: 0x4
		public static readonly int MainRenderingTransparent; //Field offset: 0x8
		public static readonly int AfterRendering; //Field offset: 0xC

		[CallerCount(Count = 0)]
		private static RenderPassBlock() { }

	}

	public struct RenderPassDescriptor
	{
		internal int w; //Field offset: 0x0
		internal int h; //Field offset: 0x4
		internal int samples; //Field offset: 0x8
		internal int depthID; //Field offset: 0xC

		[CallerCount(Count = 19)]
		[DeduplicatedMethod]
		internal RenderPassDescriptor(int width, int height, int sampleCount, int rtID) { }

	}

	private class VFXProcessCameraPassData
	{
		internal UniversalRenderingData renderingData; //Field offset: 0x10
		internal Camera camera; //Field offset: 0x18
		internal VFXCameraXRSettings cameraXRSettings; //Field offset: 0x20
		internal XRPass xrPass; //Field offset: 0x30

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public VFXProcessCameraPassData() { }

	}

	internal const int kRenderPassMapSize = 10; //Field offset: 0x0
	internal const int kRenderPassMaxCount = 20; //Field offset: 0x0
	private const int k_RenderPassBlockCount = 4; //Field offset: 0x0
	internal static ScriptableRenderer current; //Field offset: 0x0
	private static bool m_UseOptimizedStoreActions; //Field offset: 0x8
	protected static readonly RTHandle k_CameraTarget; //Field offset: 0x10
	private static RenderTargetIdentifier[] m_ActiveColorAttachmentIDs; //Field offset: 0x18
	private static RTHandle[] m_ActiveColorAttachments; //Field offset: 0x20
	private static RTHandle m_ActiveDepthAttachment; //Field offset: 0x28
	private static RenderBufferStoreAction[] m_ActiveColorStoreActions; //Field offset: 0x30
	private static RenderBufferStoreAction m_ActiveDepthStoreAction; //Field offset: 0x38
	private static RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopyIDs; //Field offset: 0x40
	private static RTHandle[][] m_TrimmedColorAttachmentCopies; //Field offset: 0x48
	private static Plane[] s_Planes; //Field offset: 0x50
	private static Vector4[] s_VectorPlanes; //Field offset: 0x58
	private int m_LastBeginSubpassPassIndex; //Field offset: 0x10
	private Dictionary<Hash128, Int32[]> m_MergeableRenderPassesMap; //Field offset: 0x18
	private Int32[][] m_MergeableRenderPassesMapArrays; //Field offset: 0x20
	private Hash128[] m_PassIndexToPassHash; //Field offset: 0x28
	private Dictionary<Hash128, Int32> m_RenderPassesAttachmentCount; //Field offset: 0x30
	private int m_firstPassIndexOfLastMergeableGroup; //Field offset: 0x38
	private AttachmentDescriptor[] m_ActiveColorAttachmentDescriptors; //Field offset: 0x40
	private AttachmentDescriptor m_ActiveDepthAttachmentDescriptor; //Field offset: 0x48
	private Boolean[] m_IsActiveColorAttachmentTransient; //Field offset: 0xC0
	internal RenderBufferStoreAction[] m_FinalColorStoreAction; //Field offset: 0xC8
	internal RenderBufferStoreAction m_FinalDepthStoreAction; //Field offset: 0xD0
	[CompilerGenerated]
	private ProfilingSampler <profilingExecute>k__BackingField; //Field offset: 0xD8
	internal bool hasReleasedRTs; //Field offset: 0xE0
	[CompilerGenerated]
	private readonly DebugHandler <DebugHandler>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private RenderingFeatures <supportedRenderingFeatures>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private GraphicsDeviceType[] <unsupportedGraphicsDeviceTypes>k__BackingField; //Field offset: 0xF8
	private StoreActionsOptimization m_StoreActionsOptimizationSetting; //Field offset: 0x100
	private List<ScriptableRenderPass> m_ActiveRenderPassQueue; //Field offset: 0x108
	private List<ScriptableRendererFeature> m_RendererFeatures; //Field offset: 0x110
	private RTHandle m_CameraColorTarget; //Field offset: 0x118
	private RTHandle m_CameraDepthTarget; //Field offset: 0x120
	private RTHandle m_CameraResolveTarget; //Field offset: 0x128
	private bool m_FirstTimeCameraColorTargetIsBound; //Field offset: 0x130
	private bool m_FirstTimeCameraDepthTargetIsBound; //Field offset: 0x131
	private bool m_IsPipelineExecuting; //Field offset: 0x132
	internal bool disableNativeRenderPassInFeatures; //Field offset: 0x133
	internal bool useRenderPassEnabled; //Field offset: 0x134
	private ContextContainer m_frameData; //Field offset: 0x138
	[CompilerGenerated]
	private bool <useDepthPriming>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private bool <stripShadowsOffVariants>k__BackingField; //Field offset: 0x141
	[CompilerGenerated]
	private bool <stripAdditionalLightOffVariants>k__BackingField; //Field offset: 0x142

	protected List<ScriptableRenderPass> activeRenderPassQueue
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[Obsolete("Use cameraColorTargetHandle", True)]
	public RenderTargetIdentifier cameraColorTarget
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 78
	}

	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public RTHandle cameraColorTargetHandle
	{
		[CalledBy(Type = typeof(ScriptableRenderPass), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScriptableRenderPass), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&), typeof(RTHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalCameraData), Member = "IsCameraProjectionMatrixFlipped", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HDRDebugViewPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessPass), Member = "<Render>g__Swap|89_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer&), typeof(<>c__DisplayClass89_0&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "RenderAndSetBaseMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer&), typeof(RenderingData&), typeof(ScriptableRenderer&), typeof(Material&), typeof(RTHandle&), typeof(RTHandle&), "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass+ShaderPasses"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalRendererFeature), Member = "SetupRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FullScreenRenderPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderingUtils), Member = "SetScaleBiasRt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CopyColorPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		 get { } //Length: 114
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("cameraDepth has been renamed to cameraDepthTarget. (UnityUpgradable) -> cameraDepthTarget", True)]
	public RenderTargetIdentifier cameraDepth
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 54
	}

	[Obsolete("Use cameraDepthTargetHandle", True)]
	public RenderTargetIdentifier cameraDepthTarget
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 78
	}

	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public RTHandle cameraDepthTargetHandle
	{
		[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalRendererFeature), Member = "SetupRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FullScreenRenderPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DepthNormalOnlyPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DepthOnlyPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		 get { } //Length: 114
	}

	internal DebugHandler DebugHandler
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal ContextContainer frameData
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	protected ProfilingSampler profilingExecute
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	protected List<ScriptableRendererFeature> rendererFeatures
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	internal bool stripAdditionalLightOffVariants
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	internal bool stripShadowsOffVariants
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public RenderingFeatures supportedRenderingFeatures
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public override bool supportsGPUOcclusion
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	internal override bool supportsNativeRenderPassRendergraphCompiler
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public GraphicsDeviceType[] unsupportedGraphicsDeviceTypes
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	internal bool useDepthPriming
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 62)]
	private static ScriptableRenderer() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraRenderType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "ResetNativeRenderPassFrameData", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_asset", ReturnType = typeof(UniversalRenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(ContextContainer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	public ScriptableRenderer(ScriptableRendererData data) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	internal void AddRenderPasses(ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Screen), Member = "SetMSAASamples", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	 int AdjustAndGetScreenMSAASamples(RenderGraph renderGraph, bool useIntermediateColorTarget) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "GetSubPassAttachmentIndicesCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool AreAttachmentIndicesCompatible(ScriptableRenderPass lastSubPass, ScriptableRenderPass currentSubPass) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnRecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRSystem), Member = "GetRenderViewportScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
	[Calls(Type = typeof(PlatformAutoDetect), Member = "get_isXRMobile", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	internal void BeginRenderGraphXRRendering(RenderGraph renderGraph) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraData), Member = "get_xr", ReturnType = typeof(XRPass))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
	[Calls(Type = typeof(XRPass), Member = "StartSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_supportsFoveatedRendering", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "ConfigureFoveatedRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	private void BeginXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetPerCameraBillboardProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetPerCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData), typeof(Camera), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Matrix4x4), Member = "get_transpose", ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 5)]
	private static void CalculateBillboardProperties(in Matrix4x4 worldToCameraMatrix, out Vector3 billboardTangent, out Vector3 billboardNormal, out float cameraXZAngle) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "RecordCustomPassesWithDepthCopyAndMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(RenderPassEvent), typeof(RenderPassEvent), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetRenderPassEventRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowMinMaxException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(void))]
	internal void CalculateSplitEventRange(RenderPassEvent startInjectionPoint, RenderPassEvent targetEvent, out RenderPassEvent startEvent, out RenderPassEvent splitEvent, out RenderPassEvent endEvent) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRendererData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	internal void Clear(CameraRenderType cameraType) { }

	[CalledBy(Type = typeof(<>c), Member = "<InitRenderGraphFrame>b__140_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 20)]
	private static void ClearRenderingState(IBaseCommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal void ConfigureCameraColorTarget(RTHandle colorTarget) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Obsolete("Use RTHandles for colorTarget and depthTarget", True)]
	public void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget, RTHandle resolveTarget) { }

	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataCIExy", "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataDebugView", typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SwapColorBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash128), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	internal static Hash128 CreateRenderPassHash(RenderPassDescriptor desc, uint hashIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash128), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	internal static Hash128 CreateRenderPassHash(int width, int height, int depthID, int sample, uint hashIndex) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugHandler), Member = "Dispose", ReturnType = typeof(void))]
	protected override void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "DestroyRenderers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "DestroyRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "GetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ScriptableRenderer))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRendererFeature), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 13327)]
	[Conditional("UNITY_EDITOR")]
	[DeduplicatedMethod]
	private void DrawGizmos(ScriptableRenderContext context, Camera camera, GizmoSubset gizmoSubset, ref RenderingData renderingData) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal void DrawRenderGraphGizmos(RenderGraph renderGraph, ContextContainer frameData, TextureHandle color, TextureHandle depth, GizmoSubset gizmoSubset) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal void DrawRenderGraphWireOverlay(RenderGraph renderGraph, ContextContainer frameData, TextureHandle color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "DrawWireOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Conditional("UNITY_EDITOR")]
	private void DrawWireOverlay(ScriptableRenderContext context, Camera camera) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void EnableSwapBufferMSAA(bool enable) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnRecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	internal void EndRenderGraphXRRendering(RenderGraph renderGraph) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_xr", ReturnType = typeof(XRPass))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "StopSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ConfigureFoveatedRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	private void EndXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData) { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FullScreenPassRendererFeature), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderObjects), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusion), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceShadows), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRawColorDepthHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "EnqueueDeferred", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void EnqueuePass(ScriptableRenderPass pass) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SortStable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Universal.ScriptableRenderPass>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "ResetNativeRenderPassFrameData", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "InternalFinishRenderingCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ConfigureFoveatedRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "StopSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "BeginXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext), typeof(CameraData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetPerCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData), typeof(Camera), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "ExecuteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderBlocks&), typeof(ScriptableRenderContext), typeof(RenderingData&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderBlocks), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Universal.ScriptableRenderPass>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetupNativeRenderPassFrameData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetShaderTimeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseCommandBuffer), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "ClearRenderingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseCommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_smoothDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "InternalStartRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CameraData), Member = "get_xr", ReturnType = typeof(XRPass))]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetupRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderingData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderBlocks), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 38)]
	[CallsUnknownMethods(Count = 26)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderBlocks), Member = "GetRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BlockRange))]
	[Calls(Type = typeof(BlockRange), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "ExecuteRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "Submit", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	private void ExecuteBlock(int blockIndex, in RenderBlocks renderBlocks, ScriptableRenderContext context, ref RenderingData renderingData, bool submit = false) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "ExecuteRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "BeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.AttachmentDescriptor>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "BeginSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "BeginSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "EndSubPass", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "GetSubPassAttachmentIndicesCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "InitializeRenderPassDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(ScriptableRenderPass)}, ReturnType = typeof(RenderPassDescriptor))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.AttachmentDescriptor>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Int32>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "EndRenderPass", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 43)]
	[ContainsUnimplementedInstructions]
	internal void ExecuteNativeRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, UniversalCameraData cameraData, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "ExecuteBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderBlocks&), typeof(ScriptableRenderContext), typeof(RenderingData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(XRPass), Member = "get_supportsFoveatedRendering", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetFoveatedRenderingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FoveatedRenderingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isRenderPassSupportedCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "ExecuteNativeRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
	[Calls(Type = typeof(XRSystemUniversal), Member = "UnmarkShaderProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(XRPassUniversal)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	private void ExecuteRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, UniversalCameraData cameraData, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetNativeRenderPassMRTAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(bool), typeof(ClearFlag)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetupInputAttachmentIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "get_loadStoreTarget", ReturnType = typeof(RenderTargetIdentifier))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static int FindAttachmentDescriptorIndexInList(RenderTargetIdentifier target, AttachmentDescriptor[] attachmentDescriptors) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RTHandle), typeof(RTHandle), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "get_loadStoreTarget", ReturnType = typeof(RenderTargetIdentifier))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal static int FindAttachmentDescriptorIndexInList(int attachmentIdx, AttachmentDescriptor attachmentDescriptor, AttachmentDescriptor[] attachmentDescriptors) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScriptableRenderer), Member = "InternalFinishRenderingCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void FinishRenderGraphRendering(CommandBuffer cmd) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void FinishRendering(CommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected List<ScriptableRenderPass> get_activeRenderPassQueue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public RenderTargetIdentifier get_cameraColorTarget() { }

	[CalledBy(Type = typeof(ScriptableRenderPass), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderPass), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&), typeof(RTHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalCameraData), Member = "IsCameraProjectionMatrixFlipped", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "<Render>g__Swap|89_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer&), typeof(<>c__DisplayClass89_0&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "RenderAndSetBaseMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer&), typeof(RenderingData&), typeof(ScriptableRenderer&), typeof(Material&), typeof(RTHandle&), typeof(RTHandle&), "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass+ShaderPasses"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "SetupRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FullScreenRenderPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "SetScaleBiasRt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CopyColorPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FinalBlitPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public RTHandle get_cameraColorTargetHandle() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public RenderTargetIdentifier get_cameraDepth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public RenderTargetIdentifier get_cameraDepthTarget() { }

	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "SetupRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FullScreenRenderPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthNormalOnlyPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthOnlyPass), Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public RTHandle get_cameraDepthTargetHandle() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal DebugHandler get_DebugHandler() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal ContextContainer get_frameData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected ProfilingSampler get_profilingExecute() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected List<ScriptableRendererFeature> get_rendererFeatures() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_stripAdditionalLightOffVariants() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_stripShadowsOffVariants() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public RenderingFeatures get_supportedRenderingFeatures() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_supportsGPUOcclusion() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal override bool get_supportsNativeRenderPassRendergraphCompiler() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public GraphicsDeviceType[] get_unsupportedGraphicsDeviceTypes() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_useDepthPriming() { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&)}, ReturnType = typeof(ClearFlag))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags", ReturnType = typeof(CameraClearFlags))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "IsActiveForCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "get_IsScreenClearNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderSettings), Member = "get_skybox", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "set_backgroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected static ClearFlag GetCameraClearFlag(UniversalCameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_universalCameraData", ReturnType = typeof(UniversalCameraData))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(ClearFlag))]
	protected static ClearFlag GetCameraClearFlag(ref CameraData cameraData) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal override RTHandle GetCameraColorBackBuffer(CommandBuffer cmd) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "UpdateFinalStoreActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "GetRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(ScriptableRenderPass), typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal static RTHandle GetFirstAllocatedRTHandle(ScriptableRenderPass pass) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "InitializeRenderPassDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(ScriptableRenderPass)}, ReturnType = typeof(RenderPassDescriptor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "GetFirstAllocatedRTHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_descriptor", ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_scaledWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_scaledHeight", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal static void GetRenderTextureDescriptor(UniversalCameraData cameraData, ScriptableRenderPass renderPass, out RenderTextureDescriptor targetRT) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "ExecuteNativeRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "AreAttachmentIndicesCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass), typeof(ScriptableRenderPass)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NativeArray`1), Member = "GetEnumerator", ReturnType = "Unity.Collections.NativeArray`1<T>+Enumerator<T>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal static uint GetSubPassAttachmentIndicesCount(ScriptableRenderPass pass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachmentDescriptor), typeof(AttachmentDescriptor)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static uint GetValidColorAttachmentCount(AttachmentDescriptor[] colorAttachments) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static int GetValidInputAttachmentCount(ScriptableRenderPass renderPass) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static int GetValidPassIndexCount(Int32[] array) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetupNativeRenderPassFrameData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "ExecuteNativeRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "GetRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(ScriptableRenderPass), typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private RenderPassDescriptor InitializeRenderPassDescriptor(UniversalCameraData cameraData, ScriptableRenderPass renderPass) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private void InitRenderGraphFrame(RenderGraph renderGraph) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "FinishRenderGraphRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "InternalFinishRenderingExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	private void InternalFinishRenderingCommon(CommandBuffer cmd, bool resolveFinalTarget) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "InternalFinishRenderingCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "ResetNativeRenderPassFrameData", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void InternalFinishRenderingExecute(ScriptableRenderContext context, CommandBuffer cmd, bool resolveFinalTarget) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void InternalStartRendering(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetRenderPassEventRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal bool InterruptFramebufferFetch(FramebufferFetchEvent fetchEvent, RenderPassEvent startInjectionPoint, RenderPassEvent endInjectionPoint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsDepthOnlyRenderTexture(RenderTexture t) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	private bool IsRenderPassEnabled(ScriptableRenderPass renderPass) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal bool IsSceneFilteringEnabled(Camera camera) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnBeginRenderGraphFrame() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnEndRenderGraphFrame() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void OnFinishRenderGraphRendering(CommandBuffer cmd) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal void OnPreCullRenderPasses(in CameraData cameraData) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool PassHasInputAttachments(ScriptableRenderPass renderPass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_viewCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	internal void ProcessVFXCameraCommand(RenderGraph renderGraph) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnRecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnBeforeRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetRenderPassEventRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPassesInEventRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, RenderPassEvent injectionPoint) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnOffscreenDepthTextureRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext), typeof(UniversalResourceData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetRenderPassEventRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPassesInEventRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, RenderPassEvent startInjectionPoint, RenderPassEvent endInjectionPoint) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "RecordCustomRenderGraphPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderPassEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RecordCustomPassesWithDepthCopyAndMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(RenderPassEvent), typeof(RenderPassEvent), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal void RecordCustomRenderGraphPassesInEventRange(RenderGraph renderGraph, RenderPassEvent eventStart, RenderPassEvent eventEnd) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext), typeof(ScriptableRenderer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RecordAndExecuteRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext), typeof(ScriptableRenderer), typeof(CommandBuffer), typeof(Camera), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SortStable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Universal.ScriptableRenderPass>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "InitRenderGraphFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 3)]
	internal void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void ReleaseRenderTargets() { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRendererData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "InternalFinishRenderingExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal void ResetNativeRenderPassFrameData() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_profilingExecute(ProfilingSampler value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_stripAdditionalLightOffVariants(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_stripShadowsOffVariants(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_supportedRenderingFeatures(RenderingFeatures value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_unsupportedGraphicsDeviceTypes(GraphicsDeviceType[] value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_useDepthPriming(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_universalCameraData", ReturnType = typeof(UniversalCameraData))]
	[Calls(Type = typeof(CameraData), Member = "IsCameraProjectionMatrixFlipped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsCameraProjectionMatrixFlipped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SetCameraMatrices(CommandBuffer cmd, UniversalCameraData cameraData, bool setInverseMatrices) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CameraData&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XRSystemUniversal), Member = "MarkShaderProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(XRPassUniversal), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
	[Calls(Type = typeof(UniversalCameraData), Member = "PushBuiltinShaderConstantsXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetCameraMatrices(RasterCommandBuffer cmd, UniversalCameraData cameraData, bool setInverseMatrices, bool isTargetFlipped) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void SetEditorTarget(RenderGraph renderGraph) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AttachmentDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "get_loadStoreTarget", ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RenderingUtils), Member = "MultisampleDepthResolveSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "ConfigureResolveTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "ConfigureClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderBuffer), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "get_depthBuffer", ReturnType = typeof(RenderBuffer))]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetupInputAttachmentIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "ConfigureTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "get_descriptor", ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "MakeRenderTextureGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(HDRColorBufferPrecision), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "FindAttachmentDescriptorIndexInList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AttachmentDescriptor), typeof(AttachmentDescriptor[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Graphics), Member = "get_preserveFramebufferAlpha", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "UpdateFinalStoreActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Int32>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 35)]
	[ContainsUnimplementedInstructions]
	internal void SetNativeRenderPassAttachmentList(ScriptableRenderPass renderPass, UniversalCameraData cameraData, RTHandle passColorAttachment, RTHandle passDepthAttachment, ClearFlag finalClearFlag, Color finalClearColor) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AttachmentDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetupInputAttachmentIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Int32>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "ConfigureClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "ConvertSRGBToActiveColorSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "ConfigureTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "FindAttachmentDescriptorIndexInList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(AttachmentDescriptor[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "MakeRenderTextureGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(HDRColorBufferPrecision), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(Graphics), Member = "get_preserveFramebufferAlpha", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderingUtils), Member = "GetValidColorBufferCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[])}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "UpdateFinalStoreActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "set_loadStoreTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 46)]
	[ContainsUnimplementedInstructions]
	internal void SetNativeRenderPassMRTAttachmentList(ScriptableRenderPass renderPass, UniversalCameraData cameraData, bool needCustomCameraColorClear, ClearFlag cameraClearFlag) { }

	[CalledBy(Type = typeof(<>c), Member = "<SetupRenderGraphCameraProperties>b__143_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(QualitySettings), Member = "get_billboardsFaceCameraPosition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "CalculateBillboardProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Vector3&), typeof(Vector3&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void SetPerCameraBillboardProperties(RasterCommandBuffer cmd, UniversalCameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsCameraProjectionMatrixFlipped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetPerCameraClippingPlaneProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetPerCameraClippingPlaneProperties(RasterCommandBuffer cmd, UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(<>c), Member = "<SetupRenderGraphCameraProperties>b__143_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetPerCameraClippingPlaneProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetPerCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData), typeof(Camera), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreMatrixUtils), Member = "MultiplyProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GeometryUtility), Member = "CalculateFrustumPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Plane[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetPerCameraClippingPlaneProperties(RasterCommandBuffer cmd, in UniversalCameraData cameraData, bool isTargetFlipped) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsCameraProjectionMatrixFlipped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetPerCameraClippingPlaneProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(QualitySettings), Member = "get_billboardsFaceCameraPosition", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "CalculateBillboardProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Vector3&), typeof(Vector3&), typeof(Single&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "SetupCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal void SetPerCameraProperties(ScriptableRenderContext context, UniversalCameraData cameraData, Camera camera, CommandBuffer cmd) { }

	[CalledBy(Type = typeof(<>c), Member = "<SetupRenderGraphCameraProperties>b__143_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetPerCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData), typeof(Camera), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_widthScaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Camera), Member = "get_orthographicSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_heightScaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_allowDynamicResolution", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private void SetPerCameraShaderVariables(RasterCommandBuffer cmd, UniversalCameraData cameraData, Vector2Int cameraTargetSizeCopy, bool isTargetFlipped) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsCameraProjectionMatrixFlipped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetPerCameraShaderVariables(RasterCommandBuffer cmd, UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "ExecuteRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetNativeRenderPassMRTAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(bool), typeof(ClearFlag)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle[]), typeof(RenderTargetIdentifier[]), typeof(RTHandle), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RenderingUtils), Member = "CountDistinct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[]), typeof(RTHandle)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[]), typeof(RTHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XRSystemUniversal), Member = "MarkShaderProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(XRPassUniversal), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
	[Calls(Type = typeof(UniversalCameraData), Member = "PushBuiltinShaderConstantsXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(ClearFlag), typeof(Color), typeof(RenderBufferStoreAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RTHandle), typeof(RTHandle), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isRenderPassSupportedCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "TryGetScreenClearColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugHandler), Member = "IsActiveForCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isPreviewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "IsMRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderingUtils), Member = "GetValidColorBufferCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[])}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(ClearFlag))]
	[Calls(Type = typeof(RenderingUtils), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[]), typeof(RenderTargetIdentifier)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderingUtils), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[]), typeof(RTHandle[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderingUtils), Member = "LastValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle[])}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	private void SetRenderPassAttachments(CommandBuffer cmd, ScriptableRenderPass renderPass, UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier[]), typeof(RTHandle), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	private static void SetRenderTarget(CommandBuffer cmd, RTHandle[] colorAttachments, RenderTargetIdentifier[] colorAttachmentIDs, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor, RenderBufferStoreAction colorStoreAction, RenderBufferStoreAction depthStoreAction) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CopyColorPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	internal static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(ClearFlag), typeof(Color), typeof(RenderBufferStoreAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(ClearFlag), typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	private static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor) { }

	[CalledBy(Type = typeof(<>c), Member = "<InitRenderGraphFrame>b__140_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<SetupRenderGraphCameraProperties>b__143_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ShaderUtils), Member = "get_PersistentDeltaTime", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 19)]
	private static void SetShaderTimeValues(IBaseCommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime) { }

	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public abstract void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetNativeRenderPassMRTAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(bool), typeof(ClearFlag)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RTHandle), typeof(RTHandle), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "FindAttachmentDescriptorIndexInList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(AttachmentDescriptor[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal void SetupInputAttachmentIndices(ScriptableRenderPass pass) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "InitializeRenderPassDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(ScriptableRenderPass)}, ReturnType = typeof(RenderPassDescriptor))]
	[Calls(Type = typeof(Hash128), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 34)]
	[ContainsUnimplementedInstructions]
	internal void SetupNativeRenderPassFrameData(UniversalCameraData cameraData, bool isRenderPassEnabled) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnRecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnBeforeRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	internal void SetupRenderGraphCameraProperties(RenderGraph renderGraph, bool isTargetBackbuffer) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	protected void SetupRenderPasses(in RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "set_loadStoreTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetupTransientInputAttachments(int attachmentCount) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SortStable(List<ScriptableRenderPass> list) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int SupportedCameraStackingTypes() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	protected private override bool SupportsCameraNormals() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	protected private override bool SupportsCameraOpaque() { }

	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "get_cameraStack", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Camera>))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool SupportsCameraStackingType(CameraRenderType cameraRenderType) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	protected private override bool SupportsMotionVectors() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void SwapColorBuffer(CommandBuffer cmd) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetNativeRenderPassMRTAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(bool), typeof(ClearFlag)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RTHandle), typeof(RTHandle), typeof(ClearFlag), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "GetFirstAllocatedRTHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RenderTexture), Member = "get_descriptor", ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_allowMSAA", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateFinalStoreActions(Int32[] currentMergeablePasses, UniversalCameraData cameraData, bool isLastMergeableGroup) { }

}

