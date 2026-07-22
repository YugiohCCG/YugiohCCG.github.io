namespace UnityEngine.Rendering.Universal;

internal class HDRDebugViewPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassDataCIExy, UnsafeGraphContext> <>9__17_0; //Field offset: 0x8
		public static BaseRenderFunc<PassDataDebugView, RasterGraphContext> <>9__17_1; //Field offset: 0x10

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
		[Calls(Type = typeof(HDRDebugViewPass), Member = "ExecuteCIExyPrepass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataCIExy", typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderHDRDebug>b__17_0(PassDataCIExy data, UnsafeGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(HDRDebugViewPass), Member = "ExecuteHDRDebugViewFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataDebugView", typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderHDRDebug>b__17_1(PassDataDebugView data, RasterGraphContext context) { }

	}

	private enum HDRDebugPassId
	{
		CIExyPrepass = 0,
		DebugViewPass = 1,
	}

	private class PassDataCIExy
	{
		internal Material material; //Field offset: 0x10
		internal Vector4 luminanceParameters; //Field offset: 0x18
		internal TextureHandle srcColor; //Field offset: 0x28
		internal TextureHandle xyBuffer; //Field offset: 0x38
		internal TextureHandle passThrough; //Field offset: 0x48

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PassDataCIExy() { }

	}

	private class PassDataDebugView
	{
		internal Material material; //Field offset: 0x10
		internal HDRDebugMode hdrDebugMode; //Field offset: 0x18
		internal UniversalCameraData cameraData; //Field offset: 0x20
		internal Vector4 luminanceParameters; //Field offset: 0x28
		internal TextureHandle overlayUITexture; //Field offset: 0x38
		internal TextureHandle xyBuffer; //Field offset: 0x48
		internal TextureHandle srcColor; //Field offset: 0x58
		internal TextureHandle dstColor; //Field offset: 0x68

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PassDataDebugView() { }

	}

	public class ShaderConstants
	{
		public static readonly int _DebugHDRModeId; //Field offset: 0x0
		public static readonly int _HDRDebugParamsId; //Field offset: 0x4
		public static readonly int _xyTextureId; //Field offset: 0x8
		public static readonly int _SizeOfHDRXYMapping; //Field offset: 0xC
		public static readonly int _CIExyUAVIndex; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderConstants() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ShaderConstants() { }

	}

	private PassDataCIExy m_PassDataCIExy; //Field offset: 0xB8
	private PassDataDebugView m_PassDataDebugView; //Field offset: 0xC0
	private RTHandle m_CIExyTarget; //Field offset: 0xC8
	private RTHandle m_PassthroughRT; //Field offset: 0xD0
	private Material m_material; //Field offset: 0xD8

	[CalledBy(Type = typeof(DebugHandler), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public HDRDebugViewPass(Material mat) { }

	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(HDRDebugMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "RenderHDRDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(HDRDebugMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useDynamicScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_enableRandomWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public static void ConfigureDescriptorForCIEPrepass(ref RenderTextureDescriptor descriptor) { }

	[CalledBy(Type = typeof(DebugHandler), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	public void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(HDRDebugViewPass), Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CameraData), Member = "get_renderer", ReturnType = typeof(ScriptableRenderer&))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraColorTargetHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RenderingUtils), Member = "GetCameraTargetIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderingData&)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RTHandleStaticHelpers), Member = "SetRTHandleStaticWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(ClearFlag), typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HDRDebugViewPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(PassDataCIExy), typeof(PassDataDebugView), typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(<>c), Member = "<RenderHDRDebug>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassDataCIExy), typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(PassDataCIExy), typeof(PassDataDebugView), typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(ClearFlag), typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRandomWriteTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
	[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRandomWriteTargets", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void ExecuteCIExyPrepass(CommandBuffer cmd, PassDataCIExy data, RTHandle sourceTexture, RTHandle xyTarget, RTHandle destTexture) { }

	[CalledBy(Type = typeof(<>c), Member = "<RenderHDRDebug>b__17_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassDataDebugView), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(PassDataCIExy), typeof(PassDataDebugView), typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RenderingUtils), Member = "GetFinalBlitScaleBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle), typeof(UniversalCameraData)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_resolveToScreen", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(HDROutputUtils), Member = "ConfigureHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(ColorGamut), typeof(Operation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(Texture))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static void ExecuteHDRDebugViewFinalPass(RasterCommandBuffer cmd, PassDataDebugView data, RTHandle sourceTexture, RTHandle destination, RTHandle xyTarget) { }

	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(HDRDebugViewPass), Member = "ExecuteCIExyPrepass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(PassDataCIExy), typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(ClearFlag), typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HDRDebugViewPass), Member = "ExecuteHDRDebugViewFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(PassDataDebugView), typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "ConfigureCameraTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	private void ExecutePass(CommandBuffer cmd, PassDataCIExy dataCIExy, PassDataDebugView dataDebugView, RTHandle sourceTexture, RTHandle xyTarget, RTHandle destTexture) { }

	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HDRDebugViewPass), Member = "RenderHDRDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(HDRDebugMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
	[Calls(Type = typeof(XRPass), Member = "get_hdrDisplayOutputInformation", ReturnType = typeof(HDRDisplayInformation))]
	[Calls(Type = typeof(HDRDisplayInformation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_paperWhiteNits", ReturnType = typeof(float))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_minToneMapLuminance", ReturnType = typeof(int))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_maxToneMapLuminance", ReturnType = typeof(int))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_maxFullFrameToneMapLuminance", ReturnType = typeof(int))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_main", ReturnType = typeof(HDROutputSettings))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeStack), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "GetHDROutputLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HDRDisplayInformation), typeof(ColorGamut), typeof(Tonemapping), typeof(Vector4&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static Vector4 GetLuminanceParameters(UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(DebugHandler), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HDRDebugViewPass), Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(DebugHandler), Member = "ConfigureColorDescriptorForDebugScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(HDRDebugViewPass), Member = "ConfigureDescriptorForCIEPrepass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "get_profilingSampler", ReturnType = typeof(ProfilingSampler))]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 46)]
	internal void RenderHDRDebug(RenderGraph renderGraph, UniversalCameraData cameraData, TextureHandle srcColor, TextureHandle overlayUITexture, TextureHandle dstColor, HDRDebugMode hdrDebugMode) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugHandler), Member = "ConfigureColorDescriptorForDebugScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HDRDebugViewPass), Member = "ConfigureDescriptorForCIEPrepass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Setup(UniversalCameraData cameraData, HDRDebugMode hdrdebugMode) { }

}

