namespace UnityEngine.Rendering;

public struct SphericalHarmonicsL1
{
	public static readonly SphericalHarmonicsL1 zero; //Field offset: 0x0
	public Vector4 shAr; //Field offset: 0x0
	public Vector4 shAg; //Field offset: 0x10
	public Vector4 shAb; //Field offset: 0x20

	[CallerCount(Count = 0)]
	private static SphericalHarmonicsL1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL1), typeof(SphericalHarmonicsL1)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static SphericalHarmonicsL1 op_Addition(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static SphericalHarmonicsL1 op_Division(SphericalHarmonicsL1 lhs, float rhs) { }

	[CalledBy(Type = typeof(SphericalHarmonicsL1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static SphericalHarmonicsL1 op_Multiply(SphericalHarmonicsL1 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static SphericalHarmonicsL1 op_Subtraction(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs) { }

}

