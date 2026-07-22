namespace UnityEngine;

[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[NativeHeader("Runtime/Misc/SystemInfoMemory.h")]
[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
public sealed class SystemInfo
{

	public static CopyTextureSupport copyTextureSupport
	{
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static DeviceType deviceType
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static FoveatedRenderingCaps foveatedRenderingCaps
	{
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static string graphicsDeviceName
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PlatformAutoDetect+PlatformDetectionCache", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PlatformAutoDetect+<>c", Member = "<.cctor>b__14_0", ReturnType = "UnityEngine.Rendering.Universal.PlatformAutoDetect+PlatformDetectionCache")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.PostProcessData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsDeviceName", ReturnType = typeof(string))]
		 get { } //Length: 9
	}

	public static GraphicsDeviceType graphicsDeviceType
	{
		[CallerCount(Count = 72)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static string graphicsDeviceVendor
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.PostProcessParams&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsDeviceVendor", ReturnType = typeof(string))]
		 get { } //Length: 9
	}

	public static int graphicsDeviceVendorID
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static int graphicsShaderLevel
	{
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool graphicsUVStartsAtTop
	{
		[CallerCount(Count = 18)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool hasHiddenSurfaceRemovalOnGPU
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static HDRDisplaySupportFlags hdrDisplaySupportFlags
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static long maxGraphicsBufferSize
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	internal static int maxRenderTextureSize
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 42
	}

	public static int maxTextureSize
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static int maxTiledPixelStorageSize
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static string operatingSystem
	{
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SystemInfo), Member = "GetOperatingSystem", ReturnType = typeof(string))]
		 get { } //Length: 9
	}

	public static OperatingSystemFamily operatingSystemFamily
	{
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static string processorType
	{
		[CalledBy(Type = "Manager.Updater+<DetermineDownloadLink>d__76", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater", Member = "get_IsARMCPU", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SystemInfo), Member = "GetProcessorType", ReturnType = typeof(string))]
		 get { } //Length: 9
	}

	public static int supportedRenderTargetCount
	{
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool supportsComputeShaders
	{
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool supportsGraphicsFence
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool supportsIndirectArgumentsBuffer
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool supportsInstancing
	{
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool supportsMultisampleAutoResolve
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool supportsMultisampledBackBuffer
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static int supportsMultisampledTextures
	{
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool supportsMultisampleResolveDepth
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool supportsMultisampleResolveStencil
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool supportsMultiview
	{
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool supportsRenderTargetArrayIndexFromVertexShader
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool supportsShadows
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool supportsStoreAndResolveAction
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool usesLoadStoreActions
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public static bool usesReversedZBuffer
	{
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static CopyTextureSupport get_copyTextureSupport() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static DeviceType get_deviceType() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static FoveatedRenderingCaps get_foveatedRenderingCaps() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PlatformAutoDetect+PlatformDetectionCache", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PlatformAutoDetect+<>c", Member = "<.cctor>b__14_0", ReturnType = "UnityEngine.Rendering.Universal.PlatformAutoDetect+PlatformDetectionCache")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.PostProcessData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsDeviceName", ReturnType = typeof(string))]
	public static string get_graphicsDeviceName() { }

	[CallerCount(Count = 72)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static GraphicsDeviceType get_graphicsDeviceType() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.PostProcessParams&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsDeviceVendor", ReturnType = typeof(string))]
	public static string get_graphicsDeviceVendor() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int get_graphicsDeviceVendorID() { }

	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int get_graphicsShaderLevel() { }

	[CallerCount(Count = 18)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_graphicsUVStartsAtTop() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_hasHiddenSurfaceRemovalOnGPU() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static HDRDisplaySupportFlags get_hdrDisplaySupportFlags() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static long get_maxGraphicsBufferSize() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int get_maxRenderTextureSize() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int get_maxTextureSize() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int get_maxTiledPixelStorageSize() { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemInfo), Member = "GetOperatingSystem", ReturnType = typeof(string))]
	public static string get_operatingSystem() { }

	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static OperatingSystemFamily get_operatingSystemFamily() { }

	[CalledBy(Type = "Manager.Updater+<DetermineDownloadLink>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "get_IsARMCPU", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemInfo), Member = "GetProcessorType", ReturnType = typeof(string))]
	public static string get_processorType() { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int get_supportedRenderTargetCount() { }

	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_supportsComputeShaders() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_supportsGraphicsFence() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_supportsIndirectArgumentsBuffer() { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_supportsInstancing() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_supportsMultisampleAutoResolve() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_supportsMultisampledBackBuffer() { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int get_supportsMultisampledTextures() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_supportsMultisampleResolveDepth() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_supportsMultisampleResolveStencil() { }

	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_supportsMultiview() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_supportsRenderTargetArrayIndexFromVertexShader() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_supportsShadows() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_supportsStoreAndResolveAction() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_usesLoadStoreActions() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool get_usesReversedZBuffer() { }

	[CalledBy(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetCopyTextureSupport")]
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("systeminfo::GetDeviceType")]
	private static DeviceType GetDeviceType() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetFoveatedRenderingCaps")]
	private static FoveatedRenderingCaps GetFoveatedRenderingCaps() { }

	[CalledBy(Type = typeof(SystemInfo), Member = "get_graphicsDeviceName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceName")]
	private static string GetGraphicsDeviceName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetGraphicsDeviceName_Injected(out ManagedSpanWrapper ret) { }

	[CallerCount(Count = 72)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceType")]
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[CalledBy(Type = typeof(SystemInfo), Member = "get_graphicsDeviceVendor", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVendor")]
	private static string GetGraphicsDeviceVendor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetGraphicsDeviceVendor_Injected(out ManagedSpanWrapper ret) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVendorID")]
	private static int GetGraphicsDeviceVendorID() { }

	[CallerCount(Count = 24)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
	private static int GetGraphicsShaderLevel() { }

	[CallerCount(Count = 18)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsUVStartsAtTop")]
	private static bool GetGraphicsUVStartsAtTop() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetHDRDisplaySupportFlags")]
	private static HDRDisplaySupportFlags GetHDRDisplaySupportFlags() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
	private static int GetMaxRenderTextureSize() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
	private static int GetMaxTextureSize() { }

	[CalledBy(Type = typeof(SystemInfo), Member = "get_operatingSystem", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction("systeminfo::GetOperatingSystem")]
	private static string GetOperatingSystem() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetOperatingSystem_Injected(out ManagedSpanWrapper ret) { }

	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("systeminfo::GetOperatingSystemFamily")]
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[CalledBy(Type = typeof(SystemInfo), Member = "get_processorType", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction("systeminfo::GetProcessorType")]
	private static string GetProcessorType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetProcessorType_Injected(out ManagedSpanWrapper ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.Universal.HDRColorBufferPrecision", typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptingGraphicsCaps::GetRenderTextureSupportedMSAASampleCount")]
	public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetRenderTextureSupportedMSAASampleCount_Injected(in RenderTextureDescriptor desc) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData", Member = "TotalAttachmentsSizeExceedPixelStorageLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData&", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray`1<PassFragmentData>&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptingGraphicsCaps::GetTiledRenderTargetStorageSize")]
	public static int GetTiledRenderTargetStorageSize(GraphicsFormat format, int sampleCount) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::HasHiddenSurfaceRemovalOnGPU")]
	private static bool HasHiddenSurfaceRemovalOnGPU() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptingGraphicsCaps::HasRenderTexture")]
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[CallerCount(Count = 39)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
	public static bool IsFormatSupported(GraphicsFormat format, GraphicsFormatUsage usage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsValidEnumValue(Enum value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::MaxGraphicsBufferSize")]
	private static long MaxGraphicsBufferSize() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::MaxTiledPixelStorageSize")]
	private static int MaxTiledPixelStorageSize() { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportedRenderTargetCount")]
	private static int SupportedRenderTargetCount() { }

	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsComputeShaders")]
	private static bool SupportsComputeShaders() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsGPUFence")]
	private static bool SupportsGPUFence() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsIndirectArgumentsBuffer")]
	private static bool SupportsIndirectArgumentsBuffer() { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsInstancing")]
	private static bool SupportsInstancing() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampleAutoResolve")]
	private static bool SupportsMultisampleAutoResolve() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampledBackBuffer")]
	private static bool SupportsMultisampledBackBuffer() { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampledTextures")]
	private static int SupportsMultisampledTextures() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampleResolveDepth")]
	private static bool SupportsMultisampleResolveDepth() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampleResolveStencil")]
	private static bool SupportsMultisampleResolveStencil() { }

	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMultiview")]
	private static bool SupportsMultiview() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsRenderTargetArrayIndexFromVertexShader")]
	private static bool SupportsRenderTargetArrayIndexFromVertexShader() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "SupportsRenderTextureFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "GetTemporaryShadowTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsShadows")]
	private static bool SupportsShadows() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::SupportsStoreAndResolveAction")]
	private static bool SupportsStoreAndResolveAction() { }

	[CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static bool SupportsTextureFormat(TextureFormat format) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::UsesLoadStoreActions")]
	private static bool UsesLoadStoreActions() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("ScriptingGraphicsCaps::UsesReversedZBuffer")]
	private static bool UsesReversedZBuffer() { }

}

