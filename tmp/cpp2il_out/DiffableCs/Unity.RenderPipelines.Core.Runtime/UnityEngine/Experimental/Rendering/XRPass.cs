namespace UnityEngine.Experimental.Rendering;

public class XRPass
{
	private readonly List<XRView> m_Views; //Field offset: 0x10
	private readonly XROcclusionMesh m_OcclusionMesh; //Field offset: 0x18
	[CompilerGenerated]
	private bool <copyDepth>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <hasMotionVectorPass>k__BackingField; //Field offset: 0x21
	[CompilerGenerated]
	private bool <spaceWarpRightHandedNDC>k__BackingField; //Field offset: 0x22
	[CompilerGenerated]
	private int <multipassId>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <cullingPassId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private RenderTargetIdentifier <renderTarget>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private RenderTextureDescriptor <renderTargetDesc>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private RenderTargetIdentifier <motionVectorRenderTarget>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private RenderTextureDescriptor <motionVectorRenderTargetDesc>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private ScriptableCullingParameters <cullingParams>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private IntPtr <foveatedRenderingInfo>k__BackingField; //Field offset: 0x728
	[CompilerGenerated]
	private float <occlusionMeshScale>k__BackingField; //Field offset: 0x730

	public private bool copyDepth
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private ScriptableCullingParameters cullingParams
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 get { } //Length: 36
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private int cullingPassId
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public bool enabled
	{
		[CallerCount(Count = 134)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 64
	}

	public private IntPtr foveatedRenderingInfo
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private bool hasMotionVectorPass
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public bool hasValidOcclusionMesh
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.XROcclusionMeshPass+<>c", Member = "<Render>b__6_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.XROcclusionMeshPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.XROcclusionMeshPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.XROcclusionMeshPass+PassData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.XROcclusionMeshPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(XROcclusionMesh), Member = "IsOcclusionMeshSupported", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRPass), Member = "GetOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 205
	}

	public ColorGamut hdrDisplayOutputColorGamut
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XRDisplaySubsystem), Member = "get_hdrOutputSettings", ReturnType = typeof(HDROutputSettings))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_displayColorGamut", ReturnType = typeof(ColorGamut))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 161
	}

	public HDRDisplayInformation hdrDisplayOutputInformation
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayInformation", ReturnType = typeof(HDRDisplayInformation))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XRDisplaySubsystem), Member = "get_hdrOutputSettings", ReturnType = typeof(HDROutputSettings))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_maxFullFrameToneMapLuminance", ReturnType = typeof(int))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_maxToneMapLuminance", ReturnType = typeof(int))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_minToneMapLuminance", ReturnType = typeof(int))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_paperWhiteNits", ReturnType = typeof(float))]
		[Calls(Type = typeof(HDRDisplayInformation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 623
	}

	public bool isFirstCameraPass
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public bool isHDRDisplayOutputActive
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XRDisplaySubsystem), Member = "get_hdrOutputSettings", ReturnType = typeof(HDROutputSettings))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_active", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 161
	}

	public bool isLastCameraPass
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 178
	}

	public private RenderTargetIdentifier motionVectorRenderTarget
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 38
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 35
	}

	public private RenderTextureDescriptor motionVectorRenderTargetDesc
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 45
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 42
	}

	public private int multipassId
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private float occlusionMeshScale
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private RenderTargetIdentifier renderTarget
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 29
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 26
	}

	public private RenderTextureDescriptor renderTargetDesc
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 36
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public bool singlePassEnabled
	{
		[CallerCount(Count = 43)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 64
	}

	public private bool spaceWarpRightHandedNDC
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public bool supportsFoveatedRendering
	{
		[CallerCount(Count = 24)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 200
	}

	public int viewCount
	{
		[CalledBy(Type = typeof(XRLayout), Member = "LogDebugInfo", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XRPass), Member = "StartSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XRGraphicsAutomatedTests), Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRLayout), typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "ProcessVFXCameraCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorsPersistentData", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<LensFlareDataDrivenComputeOcclusion>b__149_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderLensFlareDataDriven>b__150_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDrivenComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDriven", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.StpUtils", Member = "PopulateStpConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(int), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D), typeof(Config&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "UpdateCameraStereoMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRPass)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.XRSystemUniversal", Member = "BeginLateLatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.XRPassUniversal"}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 60
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRPassUniversal", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public XRPass() { }

	[CalledBy(Type = typeof(XRSystem), Member = "<CreateDefaultLayout>g__AddViewToPass|44_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRPass), typeof(XRRenderPass), typeof(int), typeof(<>c__DisplayClass44_0&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal void AddView(XRView xrView) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "SetupVignette", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(XRPass)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[CallsUnknownMethods(Count = 1)]
	public Vector4 ApplyXRViewCenterOffset(Vector2 center) { }

	[CalledBy(Type = typeof(XRGraphicsAutomatedTests), Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRLayout), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "get_cullingOptions", ReturnType = typeof(CullingOptions))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "set_cullingOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void AssignCullingParams(int cullingPassId, ScriptableCullingParameters cullingParams) { }

	[CalledBy(Type = typeof(XRGraphicsAutomatedTests), Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRLayout), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XRView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void AssignView(int viewId, XRView xrView) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRPass), Member = "InitBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRPassCreateInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static XRPass CreateDefault(XRPassCreateInfo createInfo) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_copyDepth() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	public ScriptableCullingParameters get_cullingParams() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_cullingPassId() { }

	[CallerCount(Count = 134)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_enabled() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public IntPtr get_foveatedRenderingInfo() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_hasMotionVectorPass() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.XROcclusionMeshPass+<>c", Member = "<Render>b__6_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.XROcclusionMeshPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XROcclusionMeshPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.XROcclusionMeshPass+PassData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XROcclusionMeshPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XROcclusionMesh), Member = "IsOcclusionMeshSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "GetOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_hasValidOcclusionMesh() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "get_hdrOutputSettings", ReturnType = typeof(HDROutputSettings))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_displayColorGamut", ReturnType = typeof(ColorGamut))]
	[CallsUnknownMethods(Count = 1)]
	public ColorGamut get_hdrDisplayOutputColorGamut() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayInformation", ReturnType = typeof(HDRDisplayInformation))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "get_hdrOutputSettings", ReturnType = typeof(HDROutputSettings))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_maxFullFrameToneMapLuminance", ReturnType = typeof(int))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_maxToneMapLuminance", ReturnType = typeof(int))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_minToneMapLuminance", ReturnType = typeof(int))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_paperWhiteNits", ReturnType = typeof(float))]
	[Calls(Type = typeof(HDRDisplayInformation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public HDRDisplayInformation get_hdrDisplayOutputInformation() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_isFirstCameraPass() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "get_hdrOutputSettings", ReturnType = typeof(HDROutputSettings))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_active", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_isHDRDisplayOutputActive() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_isLastCameraPass() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public RenderTargetIdentifier get_motionVectorRenderTarget() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public RenderTextureDescriptor get_motionVectorRenderTargetDesc() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_multipassId() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public float get_occlusionMeshScale() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public RenderTargetIdentifier get_renderTarget() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public RenderTextureDescriptor get_renderTargetDesc() { }

	[CallerCount(Count = 43)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_singlePassEnabled() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_spaceWarpRightHandedNDC() { }

	[CallerCount(Count = 24)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_supportsFoveatedRendering() { }

	[CalledBy(Type = typeof(XRLayout), Member = "LogDebugInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XRPass), Member = "StartSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XRGraphicsAutomatedTests), Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRLayout), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "ProcessVFXCameraCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorsPersistentData", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<LensFlareDataDrivenComputeOcclusion>b__149_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderLensFlareDataDriven>b__150_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDrivenComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDriven", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.StpUtils", Member = "PopulateStpConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(int), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D), typeof(Config&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "UpdateCameraStereoMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRPass)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRSystemUniversal", Member = "BeginLateLatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.XRPassUniversal"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	public int get_viewCount() { }

	[CalledBy(Type = typeof(XROcclusionMesh), Member = "get_hasValidOcclusionMesh", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XROcclusionMesh), Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XRPass), Member = "get_hasValidOcclusionMesh", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[CallsUnknownMethods(Count = 1)]
	public Mesh GetOcclusionMesh(int viewIndex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[CallsUnknownMethods(Count = 1)]
	public Matrix4x4 GetPrevViewMatrix(int viewIndex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[CallsUnknownMethods(Count = 1)]
	public bool GetPrevViewValid(int viewIndex = 0) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "GetProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "GetProjectionMatrixNoJitter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "GetGPUProjectionMatrixNoJitter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorsPersistentData", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "UpdateCameraStereoMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRPass)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRSystemUniversal", Member = "MarkShaderProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.XRPassUniversal", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[CallsUnknownMethods(Count = 1)]
	public Matrix4x4 GetProjMatrix(int viewIndex = 0) { }

	[CalledBy(Type = typeof(XRLayout), Member = "LogDebugInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XRGraphicsAutomatedTests), Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRLayout), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "GetCameraTargetIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(RenderTargetIdentifier))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[CallsUnknownMethods(Count = 1)]
	public int GetTextureArraySlice(int viewIndex = 0) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "PushBuiltinShaderConstantsXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorsPersistentData", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DrawSkyboxPass", Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(RendererList))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DrawSkyboxPass", Member = "CreateSkyBoxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(RendererListHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "UpdateCameraStereoMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRPass)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[CallsUnknownMethods(Count = 1)]
	public Matrix4x4 GetViewMatrix(int viewIndex = 0) { }

	[CalledBy(Type = typeof(XRGraphicsAutomatedTests), Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRLayout), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XROcclusionMeshPass+<>c", Member = "<Render>b__6_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.XROcclusionMeshPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XROcclusionMeshPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.XROcclusionMeshPass+PassData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XROcclusionMeshPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "UpdateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", typeof(XRPass&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass+PassData", typeof(RendererList), typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[CallsUnknownMethods(Count = 1)]
	public Rect GetViewport(int viewIndex = 0) { }

	[CalledBy(Type = typeof(XRPass), Member = "CreateDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRPassCreateInfo)}, ReturnType = typeof(XRPass))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRPassUniversal", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRPassCreateInfo)}, ReturnType = typeof(XRPass))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "get_cullingOptions", ReturnType = typeof(CullingOptions))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "set_cullingOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	public void InitBase(XRPassCreateInfo createInfo) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Release() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[Calls(Type = typeof(CoreUtils), Member = "CalculateViewSpaceCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector3[]))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Debug), Member = "DrawLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void RenderDebugXRViewsFrustum() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XROcclusionMesh), Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void RenderOcclusionMesh(CommandBuffer cmd, bool renderIntoTexture = false) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.XROcclusionMeshPass+<>c", Member = "<Render>b__6_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.XROcclusionMeshPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XROcclusionMeshPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.XROcclusionMeshPass+PassData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XROcclusionMeshPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XROcclusionMesh), Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void RenderOcclusionMesh(RasterCommandBuffer cmd, bool renderIntoTexture = false) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_copyDepth(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void set_cullingParams(ScriptableCullingParameters value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_cullingPassId(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_foveatedRenderingInfo(IntPtr value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_hasMotionVectorPass(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_motionVectorRenderTarget(RenderTargetIdentifier value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_motionVectorRenderTargetDesc(RenderTextureDescriptor value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_multipassId(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_occlusionMeshScale(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_renderTarget(RenderTargetIdentifier value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_renderTargetDesc(RenderTextureDescriptor value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_spaceWarpRightHandedNDC(bool value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<ProcessVFXCameraCommand>b__142_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+VFXProcessCameraPassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<BeginRenderGraphXRRendering>b__149_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+BeginXRPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	public void StartSinglePass(IRasterCommandBuffer cmd) { }

	[CalledBy(Type = typeof(XROcclusionMesh), Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LensFlareCommonSRP), Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(XRPass), typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LensFlareCommonSRP), Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), typeof(XRPass), typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), typeof(System.Func`4<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, System.Single>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "BeginXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CommandBuffer), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "get_viewCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetInstanceMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void StartSinglePass(CommandBuffer cmd) { }

	[CalledBy(Type = typeof(XROcclusionMesh), Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LensFlareCommonSRP), Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(XRPass), typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LensFlareCommonSRP), Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), typeof(XRPass), typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), typeof(System.Func`4<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, System.Single>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "EndXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetInstanceMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void StopSinglePass(CommandBuffer cmd) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<ProcessVFXCameraCommand>b__142_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+VFXProcessCameraPassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer+<>c", Member = "<EndRenderGraphXRRendering>b__151_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+EndXRPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public void StopSinglePass(BaseCommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XROcclusionMesh), Member = "UpdateCombinedMesh", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateCombinedOcclusionMesh() { }

}

