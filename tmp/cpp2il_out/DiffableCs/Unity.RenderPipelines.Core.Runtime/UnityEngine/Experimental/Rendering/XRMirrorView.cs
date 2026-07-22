namespace UnityEngine.Experimental.Rendering;

internal static class XRMirrorView
{
	private static readonly MaterialPropertyBlock s_MirrorViewMaterialProperty; //Field offset: 0x0
	private static readonly ProfilingSampler k_MirrorViewProfilingSampler; //Field offset: 0x8
	private static readonly int k_SourceTex; //Field offset: 0x10
	private static readonly int k_SourceTexArraySlice; //Field offset: 0x14
	private static readonly int k_ScaleBias; //Field offset: 0x18
	private static readonly int k_ScaleBiasRt; //Field offset: 0x1C
	private static readonly int k_SRGBRead; //Field offset: 0x20
	private static readonly int k_SRGBWrite; //Field offset: 0x24
	private static readonly int k_MaxNits; //Field offset: 0x28
	private static readonly int k_SourceMaxNits; //Field offset: 0x2C
	private static readonly int k_SourceHDREncoding; //Field offset: 0x30
	private static readonly int k_ColorTransform; //Field offset: 0x34

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static XRMirrorView() { }

	[CalledBy(Type = typeof(XRSystem), Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ColorGamutUtility), Member = "GetColorPrimaries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut)}, ReturnType = typeof(ColorPrimaries))]
	[Calls(Type = typeof(HDROutputUtils), Member = "GetColorEncodingForGamut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(math), Member = "mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(float3x3)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(Matrix4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_maxToneMapLuminance", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTexture), Member = "get_sRGB", ReturnType = typeof(bool))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(HDROutputUtils), Member = "ConfigureHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Operation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ConfigureFoveatedRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "EnableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureXR), Member = "get_useTexArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(HDROutputUtils), Member = "ConfigureHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock), typeof(ColorGamut)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_displayColorGamut", ReturnType = typeof(ColorGamut))]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(IntegratedSubsystem), Member = "get_running", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "GetPreferredMirrorBlitMode", ReturnType = typeof(int))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "GetMirrorViewBlitDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(XRMirrorViewBlitDesc&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRMirrorViewBlitDesc), Member = "GetBlitParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XRBlitParams&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_main", ReturnType = typeof(HDROutputSettings))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "AddGraphicsThreadMirrorViewBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 23)]
	[ContainsUnimplementedInstructions]
	internal static void RenderMirrorView(CommandBuffer cmd, Camera camera, Material mat, XRDisplaySubsystem display) { }

}

