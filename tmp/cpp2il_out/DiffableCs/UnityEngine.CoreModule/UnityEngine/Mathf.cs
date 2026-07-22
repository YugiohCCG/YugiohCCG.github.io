namespace UnityEngine;

[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
[NativeHeader("Runtime/Math/FloatConversion.h")]
[NativeHeader("Runtime/Math/PerlinNoise.h")]
public struct Mathf
{
	public static readonly float Epsilon; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static Mathf() { }

	[CallerCount(Count = 0)]
	public static float Abs(float f) { }

	[CallerCount(Count = 0)]
	public static int Abs(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Acos(float f) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool Approximately(float a, float b) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Atan(float f) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Atan2(float y, float x) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Ceil(float f) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static int CeilToInt(float f) { }

	[CallerCount(Count = 0)]
	public static int Clamp(int value, int min, int max) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public static float Clamp(float value, float min, float max) { }

	[CallerCount(Count = 0)]
	public static float Clamp01(float value) { }

	[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Single&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static float ClampToFloat(double value) { }

	[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int32&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
	internal static int ClampToInt(long value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(UInt32&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static uint ClampToUInt(long value) { }

	[CallerCount(Count = 0)]
	public static int ClosestPowerOfTwo(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(Color))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static Color CorrelatedColorTemperatureToRGB(float kelvin) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Cos(float f) { }

	[CalledBy(Type = typeof(Mathf), Member = "RoundBasedOnMinimumDifference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static double DiscardLeastSignificantDecimal(double v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Exp(float power) { }

	[CalledBy(Type = "UnityEngine.Rendering.STP", Member = "PackVector2ToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.FSRUtils", Member = "SetRcasConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FSRUtils", Member = "SetRcasConstantsLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FSRUtils", Member = "SetRcasConstantsLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static ushort FloatToHalf(float val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Floor(float f) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static int FloorToInt(float f) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = "SetupShaderProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "SetColorValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BMPAlloc", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "SetTextCoreSettingValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BMPAlloc", "UnityEngine.UIElements.UIR.TextCoreSettings"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ColorUtils", Member = "PrepareShadowsMidtonesHighlights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = "System.ValueTuple`3<Vector4, Vector4, Vector4>")]
	[CalledBy(Type = "UnityEngine.Rendering.ColorUtils", Member = "PrepareLiftGammaGain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(Vector4&), typeof(Vector4&)}, ReturnType = "System.ValueTuple`3<Vector4, Vector4, Vector4>")]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "ConvertSRGBToActiveColorSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "SetupBloom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "UberPostSetupBloomPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "RenderBloomTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Color), Member = "get_linear", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(LinearColor), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float)}, ReturnType = typeof(LinearColor))]
	[CallerCount(Count = 71)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static float GammaToLinearSpace(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 2)]
	internal static int GetNumberOfDecimalsForMinimumDifference(double minDifference) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float InverseLerp(float a, float b, float value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool IsPowerOfTwo(int value) { }

	[CallerCount(Count = 0)]
	public static float Lerp(float a, float b, float t) { }

	[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static float LerpAngle(float a, float b, float t) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float LerpUnclamped(float a, float b, float t) { }

	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "ConvertLinearToActiveColorSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(Color), Member = "get_gamma", ReturnType = typeof(Color))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static float LinearToGammaSpace(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public static float Log(float f, float p) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Log(float f) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Log10(float f) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static int Max(Int32[] values) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int Max(int a, int b) { }

	[CallerCount(Count = 0)]
	public static float Max(float a, float b) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static int Min(int a, int b) { }

	[CallerCount(Count = 0)]
	public static float Min(float a, float b) { }

	[CallerCount(Count = 0)]
	public static int NextPowerOfTwo(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public static float Pow(float f, float p) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Repeat(float t, float length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Round(float f) { }

	[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "DiscardLeastSignificantDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static int RoundToInt(float f) { }

	[CallerCount(Count = 0)]
	public static float Sign(float f) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Sin(float f) { }

	[CalledBy(Type = "UnityEngine.UIElements.ScrollView", Member = "SpringBack", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Sqrt(float f) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float Tan(float f) { }

}

