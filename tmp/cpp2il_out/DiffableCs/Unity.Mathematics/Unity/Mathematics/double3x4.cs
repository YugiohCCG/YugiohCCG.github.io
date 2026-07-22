namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct double3x4 : IEquatable<double3x4>, IFormattable
{
	public static readonly double3x4 zero; //Field offset: 0x0
	public double3 c0; //Field offset: 0x0
	public double3 c1; //Field offset: 0x18
	public double3 c2; //Field offset: 0x30
	public double3 c3; //Field offset: 0x48

	public double3 Item
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 12
	}

	[CallerCount(Count = 0)]
	public double3x4(double3 c0, double3 c1, double3 c2, double3 c3) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double3x4(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double3x4(uint3x4 v) { }

	[CalledBy(Type = typeof(double3x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(double3x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public double3x4(uint v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double3x4(int3x4 v) { }

	[CallerCount(Count = 0)]
	public double3x4(float3x4 v) { }

	[CalledBy(Type = typeof(double3x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool3x4)}, ReturnType = typeof(double3x4))]
	[CallerCount(Count = 1)]
	public double3x4(bool3x4 v) { }

	[CalledBy(Type = typeof(double3x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(double3x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public double3x4(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public double3x4(double v) { }

	[CallerCount(Count = 0)]
	public double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double3x4(int v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double3x4), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double3x4)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object o) { }

	[CalledBy(Type = typeof(double3x4), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 100)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(double3x4 rhs) { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public double3 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double3x4)}, ReturnType = typeof(uint))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Addition(double3x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Addition(double lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Addition(double3x4 lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Decrement(double3x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Division(double3x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Division(double3x4 lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Division(double lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Equality(double3x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Equality(double3x4 lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Equality(double lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double3x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public static double3x4 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double3x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool3x4)}, ReturnType = typeof(void))]
	public static double3x4 op_Explicit(bool3x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThan(double3x4 lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThan(double3x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThan(double lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThanOrEqual(double3x4 lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThanOrEqual(double3x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThanOrEqual(double lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double3x4 op_Implicit(float3x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double3x4 op_Implicit(int3x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double3x4 op_Implicit(double v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double3x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	public static double3x4 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double3x4 op_Implicit(uint3x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double3x4 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double3x4 op_Implicit(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Increment(double3x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Inequality(double3x4 lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Inequality(double lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Inequality(double3x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThan(double3x4 lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThan(double lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThan(double3x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThanOrEqual(double3x4 lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThanOrEqual(double3x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThanOrEqual(double lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Modulus(double lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Modulus(double3x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Modulus(double3x4 lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Multiply(double lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Multiply(double3x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Multiply(double3x4 lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Subtraction(double lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Subtraction(double3x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_Subtraction(double3x4 lhs, double3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double3x4 op_UnaryNegation(double3x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 104)]
	public static double3x4 op_UnaryPlus(double3x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 50)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 50)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

