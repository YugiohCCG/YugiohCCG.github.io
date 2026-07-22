namespace UnityEngine.Rendering;

public static class HDROutputUtils
{
	internal struct HDRDisplayInformation
	{
		public int maxFullFrameToneMapLuminance; //Field offset: 0x0
		public int maxToneMapLuminance; //Field offset: 0x4
		public int minToneMapLuminance; //Field offset: 0x8
		public float paperWhiteNits; //Field offset: 0xC

		[CalledBy(Type = typeof(XRPass), Member = "get_hdrDisplayOutputInformation", ReturnType = typeof(HDRDisplayInformation))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_hdrDisplayInformation", ReturnType = typeof(HDRDisplayInformation))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "GetLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 3)]
		public HDRDisplayInformation(int maxFullFrameToneMapLuminance, int maxToneMapLuminance, int minToneMapLuminance, float hdrPaperWhiteNits) { }

	}

	[Flags]
	internal enum Operation
	{
		None = 0,
		ColorConversion = 1,
		ColorEncoding = 2,
	}

	internal static class ShaderKeywords
	{
		public const string HDR_COLORSPACE_CONVERSION = "HDR_COLORSPACE_CONVERSION"; //Field offset: 0x0
		public const string HDR_ENCODING = "HDR_ENCODING"; //Field offset: 0x0
		public const string HDR_COLORSPACE_CONVERSION_AND_ENCODING = "HDR_COLORSPACE_CONVERSION_AND_ENCODING"; //Field offset: 0x0
		public const string HDR_INPUT = "HDR_INPUT"; //Field offset: 0x0
		internal static readonly ShaderKeyword HDRColorSpaceConversion; //Field offset: 0x0
		internal static readonly ShaderKeyword HDREncoding; //Field offset: 0x10
		internal static readonly ShaderKeyword HDRColorSpaceConversionAndEncoding; //Field offset: 0x20
		internal static readonly ShaderKeyword HDRInput; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ShaderKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private static ShaderKeywords() { }

	}

	private static class ShaderPropertyId
	{
		public static readonly int hdrColorSpace; //Field offset: 0x0
		public static readonly int hdrEncoding; //Field offset: 0x4

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderPropertyId() { }

	}


	[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "ExecuteHDRDebugViewFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataDebugView", typeof(RTHandle), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "SetupHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HDRDisplayInformation), typeof(ColorGamut), typeof(Material), typeof(Operation), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.FinalBlitPass+<>c", Member = "<Render>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.Internal.FinalBlitPass+PassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.FinalBlitPass", Member = "SetupHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut), typeof(Material), typeof(Operation), typeof(Vector4), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.FinalBlitPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(HDROutputUtils), Member = "GetColorSpaceForGamut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HDROutputUtils), Member = "GetColorEncodingForGamut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static void ConfigureHDROutput(Material material, ColorGamut gamut, Operation operations) { }

	[CalledBy(Type = typeof(XRMirrorView), Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), typeof(XRDisplaySubsystem)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HDROutputUtils), Member = "GetColorSpaceForGamut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HDROutputUtils), Member = "GetColorEncodingForGamut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void ConfigureHDROutput(MaterialPropertyBlock properties, ColorGamut gamut) { }

	[CalledBy(Type = typeof(XRMirrorView), Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), typeof(XRDisplaySubsystem)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static void ConfigureHDROutput(Material material, Operation operations) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HDROutputUtils), Member = "GetColorSpaceForGamut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HDROutputUtils), Member = "GetColorEncodingForGamut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputeShader), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static void ConfigureHDROutput(ComputeShader computeShader, ColorGamut gamut, Operation operations) { }

	[CalledBy(Type = typeof(XRMirrorView), Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), typeof(XRDisplaySubsystem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HDROutputUtils), Member = "ConfigureHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(ColorGamut), typeof(Operation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HDROutputUtils), Member = "ConfigureHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock), typeof(ColorGamut)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HDROutputUtils), Member = "ConfigureHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(ColorGamut), typeof(Operation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ColorGamutUtility), Member = "GetTransferFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut)}, ReturnType = typeof(TransferFunction))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static bool GetColorEncodingForGamut(ColorGamut gamut, out int encoding) { }

	[CalledBy(Type = typeof(HDROutputUtils), Member = "ConfigureHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(ColorGamut), typeof(Operation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HDROutputUtils), Member = "ConfigureHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock), typeof(ColorGamut)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HDROutputUtils), Member = "ConfigureHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(ColorGamut), typeof(Operation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ColorGamutUtility), Member = "GetWhitePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut)}, ReturnType = typeof(WhitePoint))]
	[Calls(Type = typeof(ColorGamutUtility), Member = "GetColorPrimaries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut)}, ReturnType = typeof(ColorPrimaries))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public static bool GetColorSpaceForGamut(ColorGamut gamut, out int colorspace) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShaderKeywordSet), Member = "IsEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderKeyword)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public static bool IsShaderVariantValid(ShaderKeywordSet shaderKeywordSet, bool isHDREnabled) { }

}

