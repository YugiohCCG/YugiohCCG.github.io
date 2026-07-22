namespace UnityEngine.Rendering.Universal;

internal static class XRSystemUniversal
{
	private static Matrix4x4[] s_projMatrix; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static XRSystemUniversal() { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRPass), Member = "get_viewCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "BeginRecordingIfLateLatched", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void BeginLateLatching(Camera camera, XRPassUniversal xrPass) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "EndRecordingIfLateLatched", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void EndLateLatching(Camera camera, XRPassUniversal xrPass) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetCameraMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(UniversalCameraData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetRenderPassAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderPass), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRPass), Member = "GetProjMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	internal static void MarkShaderProperties(RasterCommandBuffer cmd, XRPassUniversal xrPass, bool renderIntoTexture) { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "ExecuteRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(ScriptableRenderPass), typeof(UniversalCameraData), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal static void UnmarkShaderProperties(RasterCommandBuffer cmd, XRPassUniversal xrPass) { }

}

