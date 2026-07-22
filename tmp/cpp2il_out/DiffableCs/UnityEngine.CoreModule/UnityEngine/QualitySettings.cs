namespace UnityEngine;

[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettings.h")]
[StaticAccessor("GetQualitySettings()", StaticAccessorType::Dot (0))]
public sealed class QualitySettings : object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32, Int32> activeQualityLevelChanged; //Field offset: 0x0

	public static ColorSpace activeColorSpace
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_requireSrgbConversion", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(TextureFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "GetGBufferFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.Universal.HDRColorBufferPrecision", typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.PostProcessParams&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.ContextContainer"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "ConvertLinearToActiveColorSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color))]
		[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "ConvertSRGBToActiveColorSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color))]
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRSystem", Member = "RefreshDeviceInfo", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVisualElementPanel", "UnityEngine.UIElements.UIR.UIRenderDevice", "UnityEngine.UIElements.AtlasBase", "UnityEngine.UIElements.UIR.VectorImageManager"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.DynamicAtlas", Member = "OnAssignedToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IPanel"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", Member = "get_additionalLightsCookieFormat", ReturnType = typeof(GraphicsFormat))]
		[CalledBy(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
		[CallerCount(Count = 20)]
		[CallsUnknownMethods(Count = 2)]
		[NativeName("GetColorSpace")]
		[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
		 get { } //Length: 42
	}

	public static int antiAliasing
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 49
	}

	public static bool billboardsFaceCameraPosition
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraBillboardProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Camera), typeof(CommandBuffer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	public static bool enableLODCrossFade
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 51
	}

	[NativeProperty("LODBias")]
	public static float lodBias
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "CreateFrustumCullingJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), "ReadOnly&", "ReadOnly&", "Unity.Collections.NativeList`1<LODGroupCullingData>", "UnityEngine.Rendering.BinningConfig&", typeof(float), "UnityEngine.Rendering.OcclusionCullingCommon", "Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<Byte>"}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	public static int maximumLODLevel
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "CreateFrustumCullingJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), "ReadOnly&", "ReadOnly&", "Unity.Collections.NativeList`1<LODGroupCullingData>", "UnityEngine.Rendering.BinningConfig&", typeof(float), "UnityEngine.Rendering.OcclusionCullingCommon", "Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<Byte>"}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[NativeProperty("ShadowmaskMode")]
	public static ShadowmaskMode shadowmaskMode
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), "UnityEngine.Rendering.Universal.UniversalLightData", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.UnsafeCommandBuffer", "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	public static int vSyncCount
	{
		[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "InitGraphics", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
		[CalledBy(Type = "Manager.Helper", Member = "SetFPS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 49
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_requireSrgbConversion", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", Member = "get_additionalLightsCookieFormat", ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DynamicAtlas", Member = "OnAssignedToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IPanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVisualElementPanel", "UnityEngine.UIElements.UIR.UIRenderDevice", "UnityEngine.UIElements.AtlasBase", "UnityEngine.UIElements.UIR.VectorImageManager"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRSystem", Member = "RefreshDeviceInfo", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "ConvertLinearToActiveColorSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "ConvertSRGBToActiveColorSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.ContextContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.PostProcessParams&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.Universal.HDRColorBufferPrecision", typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "GetGBufferFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(TextureFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[CallsUnknownMethods(Count = 2)]
	[NativeName("GetColorSpace")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	public static ColorSpace get_activeColorSpace() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static int get_antiAliasing() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraBillboardProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Camera), typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_billboardsFaceCameraPosition() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "CreateFrustumCullingJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), "ReadOnly&", "ReadOnly&", "Unity.Collections.NativeList`1<LODGroupCullingData>", "UnityEngine.Rendering.BinningConfig&", typeof(float), "UnityEngine.Rendering.OcclusionCullingCommon", "Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<Byte>"}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static float get_lodBias() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "CreateFrustumCullingJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), "ReadOnly&", "ReadOnly&", "Unity.Collections.NativeList`1<LODGroupCullingData>", "UnityEngine.Rendering.BinningConfig&", typeof(float), "UnityEngine.Rendering.OcclusionCullingCommon", "Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<Byte>"}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int get_maximumLODLevel() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), "UnityEngine.Rendering.Universal.UniversalLightData", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.UnsafeCommandBuffer", "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static ShadowmaskMode get_shadowmaskMode() { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "InitGraphics", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static int get_vSyncCount() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_antiAliasing(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_enableLODCrossFade(bool value) { }

	[CalledBy(Type = "Manager.Helper", Member = "SetFPS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_vSyncCount(int value) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "ApplyQuality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NativeName("SetCurrentIndex")]
	public static void SetQualityLevel(int index, bool applyExpensiveChanges) { }

}

