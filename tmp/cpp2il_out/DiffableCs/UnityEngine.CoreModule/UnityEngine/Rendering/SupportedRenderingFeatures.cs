namespace UnityEngine.Rendering;

public class SupportedRenderingFeatures
{
	[Flags]
	internal enum LightmapMixedBakeModes
	{
		None = 0,
		IndirectOnly = 1,
		Subtractive = 2,
		Shadowmask = 4,
	}

	[Flags]
	internal enum ReflectionProbeModes
	{
		None = 0,
		Rotation = 1,
	}

	private static SupportedRenderingFeatures s_Active; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ReflectionProbeModes <reflectionProbeModes>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LightmapMixedBakeModes <mixedLightingModes>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LightmapsMode <lightmapsModes>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <enlightenLightmapper>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <enlighten>k__BackingField; //Field offset: 0x25
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <skyOcclusion>k__BackingField; //Field offset: 0x26
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <lightProbeProxyVolumes>k__BackingField; //Field offset: 0x27
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <motionVectors>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <receiveShadows>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <reflectionProbes>k__BackingField; //Field offset: 0x2A
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <reflectionProbesBlendDistance>k__BackingField; //Field offset: 0x2B
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <rendererPriority>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <rendersUIOverlay>k__BackingField; //Field offset: 0x2D
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesEnvironmentLighting>k__BackingField; //Field offset: 0x2E
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesFog>k__BackingField; //Field offset: 0x2F
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesRealtimeReflectionProbes>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesOtherLightingSettings>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <editableMaterialRenderQueue>k__BackingField; //Field offset: 0x32
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesLODBias>k__BackingField; //Field offset: 0x33
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesMaximumLODLevel>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesEnableLODCrossFade>k__BackingField; //Field offset: 0x35
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <rendererProbes>k__BackingField; //Field offset: 0x36
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <particleSystemInstancing>k__BackingField; //Field offset: 0x37
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <ambientProbeBaking>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <defaultReflectionProbeBaking>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesShadowmask>k__BackingField; //Field offset: 0x3A
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesLightProbeSystem>k__BackingField; //Field offset: 0x3B
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <supportsHDR>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <supportsClouds>k__BackingField; //Field offset: 0x3D
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <overridesLightProbeSystemWarningMessage>k__BackingField; //Field offset: 0x40

	public static SupportedRenderingFeatures active
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "OverridesLightProbeSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsDefaultReflectionProbeBakingSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsAmbientProbeBakingSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsUIOverlayRenderedBySRP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapsModeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapsMode), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "AdjustUIOverlayOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetSupportedRenderingFeatures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline+<>c", Member = "<.cctor>b__124_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Light[]", "Unity.Collections.NativeArray`1<LightDataGI>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "ExecuteHDRDebugViewFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataDebugView", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "FallbackMixedLightingModeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 38)]
		[Calls(Type = typeof(SupportedRenderingFeatures), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 219
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 105
	}

	public bool ambientProbeBaking
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public LightmapMixedBakeModes defaultMixedLightingModes
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool defaultReflectionProbeBaking
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool enlighten
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public LightmapBakeType lightmapBakeTypes
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public LightmapsMode lightmapsModes
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public LightmapMixedBakeModes mixedLightingModes
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool overridesLightProbeSystem
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool rendersUIOverlay
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool skyOcclusion
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool supportsHDR
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static SupportedRenderingFeatures() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SupportedRenderingFeatures() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "FallbackMixedLightingModeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "ExecuteHDRDebugViewFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataDebugView", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline+<>c", Member = "<.cctor>b__124_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Light[]", "Unity.Collections.NativeArray`1<LightDataGI>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetSupportedRenderingFeatures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "AdjustUIOverlayOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapsModeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapsMode), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsUIOverlayRenderedBySRP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsAmbientProbeBakingSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsDefaultReflectionProbeBakingSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "OverridesLightProbeSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 38)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static SupportedRenderingFeatures get_active() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_ambientProbeBaking() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_defaultReflectionProbeBaking() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_enlighten() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public LightmapBakeType get_lightmapBakeTypes() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public LightmapsMode get_lightmapsModes() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public LightmapMixedBakeModes get_mixedLightingModes() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public bool get_overridesLightProbeSystem() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_rendersUIOverlay() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void IsAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void IsDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "FallbackMixedLightingModeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsMixedLightingModeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MixedLightingMode), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupportedByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	[CalledBy(Type = typeof(SupportedRenderingFeatures), Member = "FallbackMixedLightingModeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "IsLightmapBakeTypeSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightmapBakeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportedRenderingFeatures), Member = "get_active", ReturnType = typeof(SupportedRenderingFeatures))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void OverridesLightProbeSystem(IntPtr overridesPtr) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void set_active(SupportedRenderingFeatures value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_overridesLightProbeSystem(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_rendersUIOverlay(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_skyOcclusion(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_supportsHDR(bool value) { }

}

