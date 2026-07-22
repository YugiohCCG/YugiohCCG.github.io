namespace UnityEngine.Rendering.Universal;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.Universal", null, null)]
public class RenderObjectsPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__33_0; //Field offset: 0x8

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
		[Calls(Type = typeof(UniversalCameraData), Member = "IsRenderTargetProjectionMatrixFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RendererListHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListHandle)}, ReturnType = typeof(RendererList))]
		[Calls(Type = typeof(RenderObjectsPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderObjectsPass+PassData", typeof(RasterCommandBuffer), typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RecordRenderGraph>b__33_0(PassData data, RasterGraphContext rgContext) { }

	}

	private class PassData
	{
		internal CustomCameraSettings cameraSettings; //Field offset: 0x10
		internal RenderPassEvent renderPassEvent; //Field offset: 0x18
		internal TextureHandle color; //Field offset: 0x1C
		internal RendererListHandle rendererListHdl; //Field offset: 0x2C
		internal DebugRendererLists debugRendererLists; //Field offset: 0x38
		internal UniversalCameraData cameraData; //Field offset: 0x40
		internal RendererList rendererList; //Field offset: 0x48

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PassData() { }

	}

	private RenderQueueType renderQueueType; //Field offset: 0xB8
	private FilteringSettings m_FilteringSettings; //Field offset: 0xBC
	private CustomCameraSettings m_CameraSettings; //Field offset: 0xE0
	[CompilerGenerated]
	private Material <overrideMaterial>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private int <overrideMaterialPassIndex>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private Shader <overrideShader>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private int <overrideShaderPassIndex>k__BackingField; //Field offset: 0x100
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x108
	private PassData m_PassData; //Field offset: 0x110
	private RenderStateBlock m_RenderStateBlock; //Field offset: 0x118

	public Material overrideMaterial
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

	public int overrideMaterialPassIndex
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Shader overrideShader
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

	public int overrideShaderPassIndex
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderObjectsPass), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(String[]), typeof(RenderQueueType), typeof(int), typeof(CustomCameraSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal RenderObjectsPass(URPProfileId profileId, RenderPassEvent renderPassEvent, String[] shaderTags, RenderQueueType renderQueueType, int layerMask, CustomCameraSettings cameraSettings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderObjectsPass), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(String[]), typeof(RenderQueueType), typeof(int), typeof(CustomCameraSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RenderObjectsPass(string profilerTag, RenderPassEvent renderPassEvent, String[] shaderTags, RenderQueueType renderQueueType, int layerMask, CustomCameraSettings cameraSettings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(RenderObjectsPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalLightData), typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraData), Member = "IsCameraProjectionMatrixFlipped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderObjectsPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterCommandBuffer), typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(<>c), Member = "<RecordRenderGraph>b__33_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderObjectsPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(DebugRendererLists), Member = "DrawWithRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "SetViewAndProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Matrix4x4), typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "SetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Perspective", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void ExecutePass(PassData passData, RasterCommandBuffer cmd, RendererList rendererList, bool isYFlipped) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Material get_overrideMaterial() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_overrideMaterialPassIndex() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Shader get_overrideShader() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_overrideShaderPassIndex() { }

	[CalledBy(Type = typeof(RenderObjectsPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderPassEvent), typeof(String[]), typeof(RenderQueueType), typeof(int), typeof(CustomCameraSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderObjectsPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(URPProfileId), typeof(RenderPassEvent), typeof(String[]), typeof(RenderQueueType), typeof(int), typeof(CustomCameraSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderObjects), Member = "Create", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderQueueRange), Member = "get_transparent", ReturnType = typeof(RenderQueueRange))]
	[Calls(Type = typeof(RenderQueueRange), Member = "get_opaque", ReturnType = typeof(RenderQueueRange))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.Rendering.RenderQueueRange>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderQueueRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FilteringSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Rendering.RenderQueueRange>), typeof(int), typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShaderTagId), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderStateBlock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateMask)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal void Init(RenderPassEvent renderPassEvent, String[] shaderTags, RenderQueueType renderQueueType, int layerMask, CustomCameraSettings cameraSettings) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void InitPassData(UniversalCameraData cameraData, ref PassData passData) { }

	[CalledBy(Type = typeof(RenderObjectsPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderObjectsPass), Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.ShaderTagId>), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	[Calls(Type = typeof(DrawingSettings), Member = "set_overrideMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawingSettings), Member = "set_overrideShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateRendererListWithRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings), typeof(FilteringSettings), typeof(RenderStateBlock), typeof(RendererList&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugHandler), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(DebugRendererLists))]
	[Calls(Type = typeof(RenderingUtils), Member = "CreateRendererListWithRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(DrawingSettings), typeof(FilteringSettings), typeof(RenderStateBlock), typeof(RendererListHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugHandler), Member = "CreateRendererListsWithDebugRenderState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(DrawingSettings&), typeof(FilteringSettings&), typeof(RenderStateBlock&)}, ReturnType = typeof(DebugRendererLists))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void InitRendererLists(UniversalRenderingData renderingData, UniversalLightData lightData, ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_dBuffer", ReturnType = typeof(TextureHandle[]))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_activeColorTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_activeDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_additionalShadowsTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_ssaoTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderObjectsPass), Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalLightData), typeof(PassData&), typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(DebugRendererLists), Member = "PrepareRendererListForRasterPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRasterRenderGraphBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_supportsFoveatedRendering", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 49)]
	[ContainsUnimplementedInstructions]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_overrideMaterial(Material value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_overrideMaterialPassIndex(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_overrideShader(Shader value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_overrideShaderPassIndex(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DepthState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CompareFunction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetDepthState(bool writeEnabled, CompareFunction function = 2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DepthState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CompareFunction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Obsolete("Use SetDepthState instead", True)]
	public void SetDetphState(bool writeEnabled, CompareFunction function = 2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StencilState), Member = "get_defaultValue", ReturnType = typeof(StencilState))]
	[Calls(Type = typeof(StencilState), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "SetCompareFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareFunction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "SetPassOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "SetFailOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "SetZFailOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderStateBlock), Member = "set_stencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	public void SetStencilState(int reference, CompareFunction compareFunction, StencilOp passOp, StencilOp failOp, StencilOp zFailOp) { }

}

