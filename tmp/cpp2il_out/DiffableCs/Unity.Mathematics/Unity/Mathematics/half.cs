namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
public struct half : IEquatable<half>, IFormattable
{
	public static readonly half zero; //Field offset: 0x0
	public ushort value; //Field offset: 0x0

	public static float MaxValue
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public static half MaxValueAsHalf
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 110
	}

	public static float MinValue
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "GetLightUVScaleOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalAdditionalLightData&", typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		 get { } //Length: 9
	}

	public static half MinValueAsHalf
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 110
	}

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private static half() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public half(double v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public half(half x) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public half(float v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(half rhs) { }

	[CallerCount(Count = 0)]
	public static float get_MaxValue() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static half get_MaxValueAsHalf() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "GetLightUVScaleOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalAdditionalLightData&", typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	public static float get_MinValue() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static half get_MinValueAsHalf() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(half lhs, half rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static half op_Explicit(float v) { }

	[CallerCount(Count = 54)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static half op_Explicit(double v) { }

	[CalledBy(Type = typeof(double2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(double2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(double2), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half)}, ReturnType = typeof(double2))]
	[CalledBy(Type = typeof(double2), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half2)}, ReturnType = typeof(double2))]
	[CalledBy(Type = typeof(double3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(double3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(double3), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half)}, ReturnType = typeof(double3))]
	[CalledBy(Type = typeof(double3), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half3)}, ReturnType = typeof(double3))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(math), Member = "f16tof32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	public static double op_Implicit(half d) { }

	[CalledBy(Type = typeof(float3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(float3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(float3), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half)}, ReturnType = typeof(float3))]
	[CalledBy(Type = typeof(float3), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half3)}, ReturnType = typeof(float3))]
	[CalledBy(Type = typeof(float4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(float4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(float4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half)}, ReturnType = typeof(float4))]
	[CalledBy(Type = typeof(float4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(half4)}, ReturnType = typeof(float4))]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(math), Member = "f16tof32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(float))]
	public static float op_Implicit(half d) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(half lhs, half rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "f16tof32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "f16tof32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	public virtual string ToString() { }

}

