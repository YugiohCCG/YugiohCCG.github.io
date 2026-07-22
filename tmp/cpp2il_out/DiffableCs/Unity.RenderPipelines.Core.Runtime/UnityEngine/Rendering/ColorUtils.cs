namespace UnityEngine.Rendering;

public static class ColorUtils
{
	public static float s_LightMeterCalibrationConstant; //Field offset: 0x0
	public static float s_LensAttenuation; //Field offset: 0x4

	public static float lensImperfectionExposureScale
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 100
	}

	[CallerCount(Count = 0)]
	private static ColorUtils() { }

	[CallerCount(Count = 0)]
	public static Vector3 CIExyToLMS(float x, float y) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public static float ComputeEV100(float aperture, float shutterSpeed, float ISO) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public static float ComputeEV100FromAvgLuminance(float avgLuminance) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float ComputeISO(float aperture, float shutterSpeed, float targetEV100) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float ConvertEV100ToExposure(float EV100) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public static float ConvertExposureToEV100(float exposure) { }

	[CallerCount(Count = 0)]
	public static float get_lensImperfectionExposureScale() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "SetupBloom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "UberPostSetupBloomPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle&), typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public static float Luminance(in Color color) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ValueTuple<Vector4, Vector4, Vector4> PrepareLiftGammaGain(in Vector4 inLift, in Vector4 inGamma, in Vector4 inGain) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ValueTuple<Vector4, Vector4, Vector4> PrepareShadowsMidtonesHighlights(in Vector4 inShadows, in Vector4 inMidtones, in Vector4 inHighlights) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ValueTuple<Vector4, Vector4> PrepareSplitToning(in Vector4 inShadows, in Vector4 inHighlights, float balance) { }

	[CallerCount(Count = 0)]
	public static float StandardIlluminantY(float x) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint ToHex(Color c) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static Color ToRGBA(uint hex) { }

}

