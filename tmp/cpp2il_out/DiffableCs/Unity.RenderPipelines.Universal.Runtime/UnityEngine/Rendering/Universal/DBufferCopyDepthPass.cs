namespace UnityEngine.Rendering.Universal;

internal class DBufferCopyDepthPass : CopyDepthPass
{

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(CameraData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyDepthPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(Shader), typeof(bool), typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	public DBufferCopyDepthPass(RenderPassEvent evt, Shader copyDepthShader, bool shouldClear = false, bool copyToDepth = false, bool copyResolvedDepth = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalRenderer), Member = "get_renderingModeActual", ReturnType = typeof(RenderingMode))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_dBufferDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_dBufferDepth", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(CopyDepthPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

}

