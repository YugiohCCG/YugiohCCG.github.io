namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
[StaticAccessor("GetGraphicsSettings()", StaticAccessorType::Dot (0))]
public sealed class GraphicsSettings : object
{
	private static Lazy<RenderPipelineGlobalSettings> s_CurrentRenderPipelineGlobalSettings; //Field offset: 0x0

	public static RenderPipelineAsset currentRenderPipeline
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRSystem", Member = "XRSystemInit", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphDebugParams", Member = "IsImmediateModeSupported", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphDebugParams", Member = "<GetWidgetList>b__11_8", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "get_asset", ReturnType = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicsSettings), Member = "GetDefaultShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultShaderType)}, ReturnType = typeof(Shader))]
		[CalledBy(Type = typeof(GraphicsSettings), Member = "GetDefaultMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultMaterialType)}, ReturnType = typeof(Material))]
		[CalledBy(Type = typeof(GraphicsSettings), Member = "Internal_GetCurrentRenderPipelineGlobalSettings", ReturnType = typeof(RenderPipelineGlobalSettings))]
		[CalledBy(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "IsGPUResidentDrawerSupportedBySRP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerSettings", typeof(String&), typeof(LogType&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "GetGlobalSettingsFromRPAsset", ReturnType = "UnityEngine.Rendering.GPUResidentDrawerSettings")]
		[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerSettings", typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(GraphicsSettings), Member = "get_INTERNAL_currentRenderPipeline", ReturnType = typeof(ScriptableObject))]
		 get { } //Length: 147
	}

	public static Type currentRenderPipelineAssetType
	{
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory", Member = "CreateComponentSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplaySettingsVolume+SettingsPanel", "System.Action`2<Field`1<Int32>, Int32>"}, ReturnType = "UnityEngine.Rendering.DebugUI+EnumField")]
		[CalledBy(Type = "UnityEngine.Rendering.VolumeDebugSettings`1", Member = "get_volumeComponentsPathAndType", ReturnType = "System.Collections.Generic.List`1<ValueTuple`2<String, Type>>")]
		[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.VolumeProfile", "UnityEngine.Rendering.VolumeProfile"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(GraphicsSettings), Member = "get_INTERNAL_currentRenderPipeline", ReturnType = typeof(ScriptableObject))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 225
	}

	[NativeName("CurrentRenderPipeline")]
	private static ScriptableObject INTERNAL_currentRenderPipeline
	{
		[CalledBy(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
		[CalledBy(Type = typeof(GraphicsSettings), Member = "get_isScriptableRenderPipelineEnabled", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipelineAssetType", ReturnType = typeof(Type))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 117
	}

	public static bool isScriptableRenderPipelineEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsSettings), Member = "get_INTERNAL_currentRenderPipeline", ReturnType = typeof(ScriptableObject))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		 get { } //Length: 116
	}

	public static bool lightsUseColorTemperature
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 51
	}

	public static bool lightsUseLinearIntensity
	{
		[CalledBy(Type = typeof(LinearColor), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float)}, ReturnType = typeof(LinearColor))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(Color))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 51
	}

	public static bool useScriptableRenderPipelineBatching
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 51
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static GraphicsSettings() { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRSystem", Member = "XRSystemInit", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphDebugParams", Member = "IsImmediateModeSupported", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphDebugParams", Member = "<GetWidgetList>b__11_8", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "get_asset", ReturnType = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicsSettings), Member = "GetDefaultShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultShaderType)}, ReturnType = typeof(Shader))]
	[CalledBy(Type = typeof(GraphicsSettings), Member = "GetDefaultMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultMaterialType)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(GraphicsSettings), Member = "Internal_GetCurrentRenderPipelineGlobalSettings", ReturnType = typeof(RenderPipelineGlobalSettings))]
	[CalledBy(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "IsGPUResidentDrawerSupportedBySRP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerSettings", typeof(String&), typeof(LogType&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "GetGlobalSettingsFromRPAsset", ReturnType = "UnityEngine.Rendering.GPUResidentDrawerSettings")]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerSettings", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_INTERNAL_currentRenderPipeline", ReturnType = typeof(ScriptableObject))]
	public static RenderPipelineAsset get_currentRenderPipeline() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory", Member = "CreateComponentSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplaySettingsVolume+SettingsPanel", "System.Action`2<Field`1<Int32>, Int32>"}, ReturnType = "UnityEngine.Rendering.DebugUI+EnumField")]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeDebugSettings`1", Member = "get_volumeComponentsPathAndType", ReturnType = "System.Collections.Generic.List`1<ValueTuple`2<String, Type>>")]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.VolumeProfile", "UnityEngine.Rendering.VolumeProfile"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_INTERNAL_currentRenderPipeline", ReturnType = typeof(ScriptableObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 1)]
	public static Type get_currentRenderPipelineAssetType() { }

	[CalledBy(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[CalledBy(Type = typeof(GraphicsSettings), Member = "get_isScriptableRenderPipelineEnabled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipelineAssetType", ReturnType = typeof(Type))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_INTERNAL_currentRenderPipeline_Injected() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_INTERNAL_currentRenderPipeline", ReturnType = typeof(ScriptableObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public static bool get_isScriptableRenderPipelineEnabled() { }

	[CalledBy(Type = typeof(LinearColor), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float)}, ReturnType = typeof(LinearColor))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(Color))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool get_lightsUseLinearIntensity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	[RequiredByNativeCode]
	[VisibleToOtherModules]
	internal static Material GetDefaultMaterial(DefaultMaterialType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	[RequiredByNativeCode]
	[VisibleToOtherModules]
	internal static Shader GetDefaultShader(DefaultShaderType type) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickPool", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickBlendingPool", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeVolumeSystemParameters&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.STP", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "Config&"}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.TextureHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader), typeof(Shader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", Member = "get_shaderVariantLogLevel", ReturnType = "UnityEngine.Rendering.Universal.ShaderVariantLogLevel")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", Member = "set_shaderVariantLogLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ShaderVariantLogLevel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderPass", Member = "get_profilingSampler", ReturnType = "UnityEngine.Rendering.ProfilingSampler")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalRendererFeature", Member = "RecreateSystemsIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer", "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerSettings", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(RenderPipelineGlobalSettings), Member = "TryGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IRenderPipelineGraphicsSettings&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsSettings), Member = "TryGetCurrentRenderPipelineGlobalSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineGlobalSettings&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public static T GetRenderPipelineSettings() { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderPipelineGlobalSettings`2+<>c", Member = "<.cctor>b__5_0", ReturnType = "TGlobalRenderPipelineSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GraphicsSettings), Member = "Internal_GetSettingsForRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static RenderPipelineGlobalSettings GetSettingsForRenderPipeline() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PlatformAutoDetect+PlatformDetectionCache", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PlatformAutoDetect+<>c", Member = "<.cctor>b__14_0", ReturnType = "UnityEngine.Rendering.Universal.PlatformAutoDetect+PlatformDetectionCache")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Graphics), Member = "get_activeTier", ReturnType = typeof(GraphicsTier))]
	[CallsUnknownMethods(Count = 2)]
	public static bool HasShaderDefine(BuiltinShaderDefine defineHash) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderPipelineAsset), Member = "get_pipelineTypeFullName", ReturnType = typeof(string))]
	[Calls(Type = typeof(GraphicsSettings), Member = "Internal_GetSettingsForRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Object))]
	[CallsUnknownMethods(Count = 1)]
	private static RenderPipelineGlobalSettings Internal_GetCurrentRenderPipelineGlobalSettings() { }

	[CalledBy(Type = typeof(GraphicsSettings), Member = "GetSettingsForRenderPipeline", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(RenderPipelineGlobalSettings))]
	[CalledBy(Type = typeof(GraphicsSettings), Member = "Internal_GetCurrentRenderPipelineGlobalSettings", ReturnType = typeof(RenderPipelineGlobalSettings))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[NativeName("GetSettingsForRenderPipeline")]
	private static object Internal_GetSettingsForRenderPipeline(string renderpipelineName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Internal_GetSettingsForRenderPipeline_Injected(ref ManagedSpanWrapper renderpipelineName) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_lightsUseColorTemperature(bool value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_lightsUseLinearIntensity(bool value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_useScriptableRenderPipelineBatching(bool value) { }

	[CalledBy(Type = typeof(GraphicsSettings), Member = "GetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool TryGetCurrentRenderPipelineGlobalSettings(out RenderPipelineGlobalSettings asset) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", Member = "get_enableRenderGraph", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+RuntimeDebugShadersMessageBox+<>c", Member = "<.ctor>b__0_0", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "TryCreateDebugRenderData", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", Member = "get_terrainDetailLitShader", ReturnType = typeof(Shader))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", Member = "get_terrainDetailGrassShader", ReturnType = typeof(Shader))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", Member = "get_terrainDetailGrassBillboardShader", ReturnType = typeof(Shader))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion", Member = "TryPrepareResources", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(RenderPipelineGlobalSettings), Member = "TryGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IRenderPipelineGraphicsSettings&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsSettings), Member = "TryGetCurrentRenderPipelineGlobalSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineGlobalSettings&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool TryGetRenderPipelineSettings(out T settings) { }

}

