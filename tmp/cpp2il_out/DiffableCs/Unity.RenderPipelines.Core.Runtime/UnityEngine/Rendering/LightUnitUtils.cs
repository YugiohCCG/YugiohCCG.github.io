namespace UnityEngine.Rendering;

public static class LightUnitUtils
{
	public const float SphereSolidAngle = 12.566371; //Field offset: 0x0

	private static float k_EvToLuminanceFactor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LightUnitUtils), Member = "get_k_LuminanceToEvFactor", ReturnType = typeof(float))]
		private get { } //Length: 23
	}

	private static float k_LuminanceToEvFactor
	{
		[CalledBy(Type = typeof(LightUnitUtils), Member = "get_k_EvToLuminanceFactor", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LightUnitUtils), Member = "Ev100ToNits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LightUnitUtils), Member = "NitsToEv100", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LightUnitUtils), Member = "Ev100ToCandela", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 169
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightUnitUtils), Member = "NitsToEv100", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	public static float CandelaToEv100(float candela) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float CandelaToLumen(float candela, float solidAngle) { }

	[CallerCount(Count = 0)]
	public static float CandelaToLux(float candela, float distance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Light), Member = "get_type", ReturnType = typeof(LightType))]
	[Calls(Type = typeof(Light), Member = "get_areaSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Light), Member = "get_luxAtDistance", ReturnType = typeof(float))]
	[Calls(Type = typeof(Light), Member = "get_enableSpotReflector", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_spotAngle", ReturnType = typeof(float))]
	[Calls(Type = typeof(LightUnitUtils), Member = "GetSolidAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightType), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(LightUnitUtils), Member = "ConvertIntensityInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(LightUnit), typeof(LightUnit), typeof(LightType), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public static float ConvertIntensity(Light light, float intensity, LightUnit fromUnit, LightUnit toUnit) { }

	[CalledBy(Type = typeof(LightUnitUtils), Member = "ConvertIntensity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(float), typeof(LightUnit), typeof(LightUnit)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	internal static float ConvertIntensityInternal(float intensity, LightUnit fromUnit, LightUnit toUnit, LightType lightType, float area, float luxAtDistance, float solidAngle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightUnitUtils), Member = "get_k_LuminanceToEvFactor", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static float Ev100ToCandela(float ev100) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightUnitUtils), Member = "get_k_LuminanceToEvFactor", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static float Ev100ToNits(float ev100) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightUnitUtils), Member = "get_k_LuminanceToEvFactor", ReturnType = typeof(float))]
	private static float get_k_EvToLuminanceFactor() { }

	[CalledBy(Type = typeof(LightUnitUtils), Member = "get_k_EvToLuminanceFactor", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LightUnitUtils), Member = "Ev100ToNits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LightUnitUtils), Member = "NitsToEv100", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LightUnitUtils), Member = "Ev100ToCandela", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	private static float get_k_LuminanceToEvFactor() { }

	[CallerCount(Count = 0)]
	public static float GetAreaFromDiscLight(float discRadius) { }

	[CallerCount(Count = 0)]
	public static float GetAreaFromRectangleLight(Vector2 rectSize) { }

	[CallerCount(Count = 0)]
	public static float GetAreaFromRectangleLight(float rectSizeX, float rectSizeY) { }

	[CallerCount(Count = 0)]
	public static float GetAreaFromTubeLight(float tubeLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static LightUnit GetNativeLightUnit(LightType lightType) { }

	[CalledBy(Type = typeof(LightUnitUtils), Member = "ConvertIntensity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(float), typeof(LightUnit), typeof(LightUnit)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	internal static float GetSolidAngle(LightType lightType, bool spotReflector, float spotAngle, float aspectRatio) { }

	[CallerCount(Count = 0)]
	public static float GetSolidAngleFromPointLight() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static float GetSolidAngleFromPyramidLight(float spotAngle, float aspectRatio) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float GetSolidAngleFromSpotLight(float spotAngle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool IsLightUnitSupported(LightType lightType, LightUnit lightUnit) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float LumenToCandela(float lumen, float solidAngle) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float LumenToNits(float lumen, float area) { }

	[CallerCount(Count = 0)]
	public static float LuxToCandela(float lux, float distance) { }

	[CalledBy(Type = typeof(LightUnitUtils), Member = "CandelaToEv100", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(LightUnitUtils), Member = "get_k_LuminanceToEvFactor", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	public static float NitsToEv100(float nits) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float NitsToLumen(float nits, float area) { }

}

