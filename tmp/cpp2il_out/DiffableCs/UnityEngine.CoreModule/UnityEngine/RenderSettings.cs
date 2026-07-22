namespace UnityEngine;

[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
[NativeHeader("Runtime/Camera/RenderSettings.h")]
[StaticAccessor("GetRenderSettings()", StaticAccessorType::Dot (0))]
public sealed class RenderSettings : object
{

	public static Color ambientEquatorColor
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 60
	}

	public static Color ambientGroundColor
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 60
	}

	public static float ambientIntensity
	{
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 58
	}

	[NativeProperty("AmbientSkyColor")]
	public static Color ambientLight
	{
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 51
	}

	public static AmbientMode ambientMode
	{
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 49
	}

	public static SphericalHarmonicsL2 ambientProbe
	{
		[CalledBy(Type = "UnityEngine.Rendering.BatchRendererGroupGlobals", Member = "get_Default", ReturnType = "UnityEngine.Rendering.BatchRendererGroupGlobals")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderersBatchersContextDesc&", typeof(GPUDrivenProcessor), "UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = "UpdateAmbientProbeAndGpuBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		[NativeMethod("GetFinalAmbientProbe")]
		 get { } //Length: 84
	}

	public static Color ambientSkyColor
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 60
	}

	[NativeProperty("UseFog")]
	public static bool fog
	{
		[CalledBy(Type = "Extensions.FogController", Member = "BeginFog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.FogController", Member = "OnPreRender", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderFog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.FogController", Member = "BeginFog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.FogController", Member = "EndFog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.FogController", Member = "OnPreRender", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.FogController", Member = "OnPostRender", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 51
	}

	public static Color fogColor
	{
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 51
	}

	public static float fogDensity
	{
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 58
	}

	public static FogMode fogMode
	{
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 49
	}

	public static float reflectionIntensity
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 58
	}

	[NativeProperty("SkyboxMaterial")]
	public static Material skybox
	{
		[CalledBy(Type = "Manager.Background", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Background", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = "UnityEngine.Rendering.ClearFlag")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 84
		[CalledBy(Type = "Manager.Background", Member = "SetSkybox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 107
	}

	public static Color subtractiveShadowColor
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 60
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 51
	}

	public static Light sun
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "GetMainLightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", "Unity.Collections.NativeArray`1<VisibleLight>"}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 84
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 107
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Color get_ambientEquatorColor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_ambientEquatorColor_Injected(out Color ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Color get_ambientGroundColor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_ambientGroundColor_Injected(out Color ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.BatchRendererGroupGlobals", Member = "get_Default", ReturnType = "UnityEngine.Rendering.BatchRendererGroupGlobals")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderersBatchersContextDesc&", typeof(GPUDrivenProcessor), "UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = "UpdateAmbientProbeAndGpuBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod("GetFinalAmbientProbe")]
	public static SphericalHarmonicsL2 get_ambientProbe() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Color get_ambientSkyColor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_ambientSkyColor_Injected(out Color ret) { }

	[CalledBy(Type = "Extensions.FogController", Member = "BeginFog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.FogController", Member = "OnPreRender", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "RenderFog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_fog() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static float get_reflectionIntensity() { }

	[CalledBy(Type = "Manager.Background", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Background", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = "UnityEngine.Rendering.ClearFlag")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	public static Material get_skybox() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_skybox_Injected() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Color get_subtractiveShadowColor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_subtractiveShadowColor_Injected(out Color ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "GetMainLightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", "Unity.Collections.NativeArray`1<VisibleLight>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	public static Light get_sun() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_sun_Injected() { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_ambientIntensity(float value) { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_ambientLight(Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_ambientLight_Injected(in Color value) { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_ambientMode(AmbientMode value) { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.FogController", Member = "BeginFog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.FogController", Member = "EndFog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.FogController", Member = "OnPreRender", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.FogController", Member = "OnPostRender", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_fog(bool value) { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_fogColor(Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_fogColor_Injected(in Color value) { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_fogDensity(float value) { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_fogMode(FogMode value) { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_reflectionIntensity(float value) { }

	[CalledBy(Type = "Manager.Background", Member = "SetSkybox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void set_skybox(Material value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_skybox_Injected(IntPtr value) { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_subtractiveShadowColor(Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_subtractiveShadowColor_Injected(in Color value) { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void set_sun(Light value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_sun_Injected(IntPtr value) { }

}

