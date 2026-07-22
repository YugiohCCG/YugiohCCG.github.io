namespace UnityEngine.Experimental.Rendering;

public static class XRSystem
{
	[CompilerGenerated]
	private struct <>c__DisplayClass44_0
	{
		public Camera camera; //Field offset: 0x0

	}

	private static XRLayoutStack s_Layout; //Field offset: 0x0
	private static Func<XRPassCreateInfo, XRPass> s_PassAllocator; //Field offset: 0x8
	private static List<XRDisplaySubsystem> s_DisplayList; //Field offset: 0x10
	private static XRDisplaySubsystem s_Display; //Field offset: 0x18
	private static MSAASamples s_MSAASamples; //Field offset: 0x20
	private static float s_OcclusionMeshScaling; //Field offset: 0x24
	private static Material s_OcclusionMeshMaterial; //Field offset: 0x28
	private static Material s_MirrorViewMaterial; //Field offset: 0x30
	private static Action<XRLayout, Camera> s_LayoutOverride; //Field offset: 0x38
	public static readonly XRPass emptyPass; //Field offset: 0x40
	[CompilerGenerated]
	private static bool <singlePassAllowed>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private static FoveatedRenderingCaps <foveatedRenderingCaps>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private static bool <dumpDebugInfo>k__BackingField; //Field offset: 0x50

	public static bool displayActive
	{
		[CalledBy(Type = typeof(XRLayout), Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XRLayout), Member = "LogDebugInfo", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "HDROutputForAnyDisplayIsActive", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "AdjustUIOverlayOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(IntegratedSubsystem), Member = "get_running", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 134
	}

	public static bool dumpDebugInfo
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 84
	}

	public static FoveatedRenderingCaps foveatedRenderingCaps
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 83
	}

	public static bool isHDRDisplayOutputActive
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "HDROutputForAnyDisplayIsActive", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XRDisplaySubsystem), Member = "get_hdrOutputSettings", ReturnType = typeof(HDROutputSettings))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_active", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 183
	}

	public static bool singlePassAllowed
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 84
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private static XRSystem() { }

	[CalledBy(Type = typeof(XRSystem), Member = "CreateDefaultLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRLayout)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRRenderPass), Member = "GetRenderParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(int), typeof(XRRenderParameter&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSystem), Member = "BuildView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRRenderPass), typeof(XRRenderParameter)}, ReturnType = typeof(XRView))]
	[Calls(Type = typeof(XRPass), Member = "AddView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRView)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void <CreateDefaultLayout>g__AddViewToPass|44_0(XRPass xrPass, XRRenderPass renderPass, int renderParamIndex, ref <>c__DisplayClass44_0 unnamed_param_3) { }

	[CalledBy(Type = typeof(XRSystem), Member = "CreateDefaultLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRLayout)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_sRGB", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static XRPassCreateInfo BuildPass(XRRenderPass xrRenderPass, ScriptableCullingParameters cullingParameters, XRLayout layout) { }

	[CalledBy(Type = typeof(XRSystem), Member = "ReconfigurePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRPass), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XRSystem), Member = "<CreateDefaultLayout>g__AddViewToPass|44_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRPass), typeof(XRRenderPass), typeof(int), typeof(<>c__DisplayClass44_0&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4), typeof(bool), typeof(Rect), typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static XRView BuildView(XRRenderPass renderPass, XRRenderParameter renderParameter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRRenderPass), Member = "GetRenderParameterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(XRRenderPass), Member = "GetRenderParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(int), typeof(XRRenderParameter&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static bool CanUseSinglePass(Camera camera, XRRenderPass renderPass) { }

	[CalledBy(Type = typeof(XRLayout), Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "GetRenderPassCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "GetRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XRRenderPass&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "GetCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(int), typeof(ScriptableCullingParameters&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRRenderPass), Member = "GetRenderParameterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(XRRenderPass), Member = "GetRenderParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(int), typeof(XRRenderParameter&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSystem), Member = "BuildPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRRenderPass), typeof(ScriptableCullingParameters), typeof(XRLayout)}, ReturnType = typeof(XRPassCreateInfo))]
	[Calls(Type = typeof(XRSystem), Member = "<CreateDefaultLayout>g__AddViewToPass|44_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRPass), typeof(XRRenderPass), typeof(int), typeof(<>c__DisplayClass44_0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRLayout), Member = "AddPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRPass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	internal static void CreateDefaultLayout(Camera camera, XRLayout layout) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void Dispose() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(XRLayout), Member = "LogDebugInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(XRLayoutStack), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void EndLayout() { }

	[CalledBy(Type = typeof(XRLayout), Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XRLayout), Member = "LogDebugInfo", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "HDROutputForAnyDisplayIsActive", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "AdjustUIOverlayOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(IntegratedSubsystem), Member = "get_running", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_displayActive() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static bool get_dumpDebugInfo() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static FoveatedRenderingCaps get_foveatedRenderingCaps() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "HDROutputForAnyDisplayIsActive", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "get_hdrOutputSettings", ReturnType = typeof(HDROutputSettings))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_active", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool get_isHDRDisplayOutputActive() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static bool get_singlePassAllowed() { }

	[CallerCount(Count = 0)]
	public static XRDisplaySubsystem GetActiveDisplay() { }

	[CallerCount(Count = 0)]
	public static MSAASamples GetDisplayMSAASamples() { }

	[CalledBy(Type = typeof(XRSRPSettings), Member = "get_mirrorViewMode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "GetPreferredMirrorBlitMode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal static int GetMirrorViewMode() { }

	[CallerCount(Count = 0)]
	internal static float GetOcclusionMeshScale() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "BeginRenderGraphXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "get_appliedViewportScale", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public static float GetRenderViewportScale() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRSystem), Member = "RefreshDeviceInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "CreateEngineMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(GlobalKeyword), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GlobalKeyword))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public static void Initialize(Func<XRPassCreateInfo, XRPass> passAllocator, Shader occlusionMeshPS, Shader mirrorViewPS) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRSystem), Member = "RefreshDeviceInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static XRLayout NewLayout() { }

	[CalledBy(Type = typeof(XRLayout), Member = "ReconfigurePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRPass), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "GetRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XRRenderPass&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "GetCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(int), typeof(ScriptableCullingParameters&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "get_cullingOptions", ReturnType = typeof(CullingOptions))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "set_cullingOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRRenderPass), Member = "GetRenderParameterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(XRRenderPass), Member = "GetRenderParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(int), typeof(XRRenderParameter&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSystem), Member = "BuildView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRRenderPass), typeof(XRRenderParameter)}, ReturnType = typeof(XRView))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XRView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	internal static void ReconfigurePass(XRPass xrPass, Camera camera) { }

	[CalledBy(Type = typeof(XRSystem), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Experimental.Rendering.XRPassCreateInfo, UnityEngine.Experimental.Rendering.XRPass>), typeof(Shader), typeof(Shader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XRSystem), Member = "NewLayout", ReturnType = typeof(XRLayout))]
	[CalledBy(Type = typeof(XRSystem), Member = "XRSystemInit", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SubsystemManager), Member = "GetSubsystems", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "set_disableLegacyRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "set_textureLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureLayout)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static void RefreshDeviceInfo() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRMirrorView), Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), typeof(XRDisplaySubsystem)}, ReturnType = typeof(void))]
	public static void RenderMirrorView(CommandBuffer cmd, Camera camera) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static void set_dumpDebugInfo(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static void set_foveatedRenderingCaps(FoveatedRenderingCaps value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static void set_singlePassAllowed(bool value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SubsystemManager), Member = "GetSubsystems", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "SetMSAALevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void SetDisplayMSAASamples(MSAASamples msaaSamples) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "set_zNear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "set_zFar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetDisplayZRange(float zNear, float zFar) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void SetLayoutOverride(Action<XRLayout, Camera> action) { }

	[CalledBy(Type = typeof(XRSRPSettings), Member = "set_mirrorViewMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "SetPreferredMirrorBlitMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetMirrorViewMode(int mirrorBlitMode) { }

	[CallerCount(Count = 0)]
	internal static void SetOcclusionMeshScale(float occlusionMeshScale) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SubsystemManager), Member = "GetSubsystems", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "set_scaleOfAllRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void SetRenderScale(float renderScale) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_sRGB", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static RenderTextureDescriptor XrRenderTextureDescToUnityRenderTextureDesc(RenderTextureDescriptor xrDesc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRSystem), Member = "RefreshDeviceInfo", ReturnType = typeof(void))]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSplashScreen (3))]
	private static void XRSystemInit() { }

}

