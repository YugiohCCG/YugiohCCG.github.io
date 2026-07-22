namespace UnityEngine.Rendering;

public struct SHCoefficients : IEquatable<SHCoefficients>
{
	public Vector4 SHAr; //Field offset: 0x0
	public Vector4 SHAg; //Field offset: 0x10
	public Vector4 SHAb; //Field offset: 0x20
	public Vector4 SHBr; //Field offset: 0x30
	public Vector4 SHBg; //Field offset: 0x40
	public Vector4 SHBb; //Field offset: 0x50
	public Vector4 SHC; //Field offset: 0x60
	public Vector4 ProbesOcclusion; //Field offset: 0x70

	[CalledBy(Type = typeof(SHCoefficients), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BatchRendererGroupGlobals), Member = "get_Default", ReturnType = typeof(BatchRendererGroupGlobals))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	public SHCoefficients(SphericalHarmonicsL2 sh) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHCoefficients), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2)}, ReturnType = typeof(void))]
	public SHCoefficients(SphericalHarmonicsL2 sh, Vector4 probesOcclusion) { }

	[CalledBy(Type = typeof(SHCoefficients), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SHCoefficients), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SHCoefficients), typeof(SHCoefficients)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SHCoefficients), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SHCoefficients), typeof(SHCoefficients)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BatchRendererGroupGlobals), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroupGlobals)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(SHCoefficients other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHCoefficients), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SHCoefficients)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8"}, ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	private static Vector4 GetSHA(SphericalHarmonicsL2 sh, int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	private static Vector4 GetSHB(SphericalHarmonicsL2 sh, int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	private static Vector4 GetSHC(SphericalHarmonicsL2 sh) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHCoefficients), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SHCoefficients)}, ReturnType = typeof(bool))]
	public static bool op_Equality(SHCoefficients left, SHCoefficients right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHCoefficients), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SHCoefficients)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(SHCoefficients left, SHCoefficients right) { }

}

