namespace UnityEngine.Rendering.Universal;

internal static class StpUtils
{
	internal static JitterFunc s_JitterFunc; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private static StpUtils() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(STP), Member = "Jit16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	private static void CalculateJitter(int frameIndex, out Vector2 jitter, out bool allowScaling) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderSTP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(DebugHandler), Member = "TryGetFullscreenDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugFullScreenMode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(DebugHandler), Member = "get_stpDebugViewIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalResourceData), Member = "set_stpDebugView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StpUtils), Member = "PopulateStpConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(int), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D), typeof(Config&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(STP), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Config&)}, ReturnType = typeof(TextureHandle))]
	[CallsUnknownMethods(Count = 3)]
	internal static void Execute(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, TextureHandle inputColor, TextureHandle inputDepth, TextureHandle inputMotion, TextureHandle destination, Texture2D noiseTexture) { }

	[CalledBy(Type = typeof(StpUtils), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StpHistory), Member = "GetHistoryContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HistoryContext))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_resetHistory", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_viewCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Matrix4x4), Member = "SetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void PopulateStpConfig(UniversalCameraData cameraData, TextureHandle inputColor, TextureHandle inputDepth, TextureHandle inputMotion, int debugViewIndex, TextureHandle debugView, TextureHandle destination, Texture2D noiseTexture, out Config config) { }

}

