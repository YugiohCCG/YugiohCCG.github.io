namespace UnityEngine.Rendering.Universal;

public class DrawSkyboxPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__7_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RendererListHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListHandle)}, ReturnType = typeof(RendererList))]
		[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		internal void <Render>b__7_0(PassData data, RasterGraphContext context) { }

	}

	private class PassData
	{
		internal XRPass xr; //Field offset: 0x10
		internal RendererListHandle skyRendererListHandle; //Field offset: 0x18
		internal Material material; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PassData() { }

	}


	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public DrawSkyboxPass(RenderPassEvent evt) { }

	[CalledBy(Type = typeof(DrawSkyboxPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(XRPass), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(RendererList))]
	[CallsUnknownMethods(Count = 1)]
	private RendererList CreateSkyboxRendererList(ScriptableRenderContext context, UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(DrawSkyboxPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(ScriptableRenderContext), typeof(TextureHandle), typeof(TextureHandle), typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera&)}, ReturnType = typeof(RendererListHandle))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(XRPass), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(RendererListHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera&), typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(RendererListHandle))]
	[CallsUnknownMethods(Count = 1)]
	private RendererListHandle CreateSkyBoxRendererList(RenderGraph renderGraph, UniversalCameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(DebugHandler), Member = "get_IsScreenClearNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DrawSkyboxPass), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static void ExecutePass(RasterCommandBuffer cmd, XRPass xr, RendererList rendererList) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void InitPassData(ref PassData passData, in XRPass xr, in RendererListHandle handle) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(DebugHandler), Member = "get_IsScreenClearNeeded", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(DrawSkyboxPass), Member = "CreateSkyBoxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData)}, ReturnType = typeof(RendererListHandle))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_supportsFoveatedRendering", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 28)]
	[ContainsUnimplementedInstructions]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, ScriptableRenderContext context, TextureHandle colorTarget, TextureHandle depthTarget, Material skyboxMaterial) { }

}

