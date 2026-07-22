namespace UnityEngine.Rendering.Universal;

public class XROcclusionMeshPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__6_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRPass), Member = "get_hasValidOcclusionMesh", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRPass), Member = "GetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Rect))]
		[Calls(Type = typeof(XRPass), Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal void <Render>b__6_0(PassData data, RasterGraphContext context) { }

	}

	private class PassData
	{
		internal XRPass xr; //Field offset: 0x10
		internal TextureHandle cameraColorAttachment; //Field offset: 0x18
		internal TextureHandle cameraDepthAttachment; //Field offset: 0x28
		internal bool isActiveTargetBackBuffer; //Field offset: 0x38

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PassData() { }

	}

	private PassData m_PassData; //Field offset: 0xB8
	public bool m_IsActiveTargetBackBuffer; //Field offset: 0xC0

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XROcclusionMeshPass(RenderPassEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_xr", ReturnType = typeof(XRPass))]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(XRPass), Member = "get_hasValidOcclusionMesh", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "GetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(XRPass), Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRPass), Member = "get_hasValidOcclusionMesh", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "GetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(XRPass), Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData data) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_isActiveTargetBackBuffer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
	[Calls(Type = typeof(XRPass), Member = "get_supportsFoveatedRendering", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 28)]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle cameraColorAttachment, in TextureHandle cameraDepthAttachment) { }

}

