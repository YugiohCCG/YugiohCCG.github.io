namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct double4x2 : IEquatable<double4x2>, IFormattable
{
	public static readonly double4x2 zero; //Field offset: 0x0
	public double4 c0; //Field offset: 0x0
	public double4 c1; //Field offset: 0x20

	public double4 Item
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	public double4x2(double4 c0, double4 c1) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public double4x2(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double4x2(uint4x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double4x2(uint v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double4x2(int4x2 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public double4x2(float4x2 v) { }

	[CalledBy(Type = typeof(double4x2), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x2)}, ReturnType = typeof(double4x2))]
	[CallerCount(Count = 1)]
	public double4x2(bool4x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double4x2(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public double4x2(double v) { }

	[CallerCount(Count = 0)]
	public double4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public double4x2(int v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(double4x2 rhs) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public double4 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4x2)}, ReturnType = typeof(uint))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Addition(double4x2 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Addition(double lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Addition(double4x2 lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Decrement(double4x2 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Division(double4x2 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Division(double4x2 lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Division(double lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Equality(double4x2 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Equality(double4x2 lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Equality(double lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x2 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double4x2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x2)}, ReturnType = typeof(void))]
	public static double4x2 op_Explicit(bool4x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThan(double4x2 lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThan(double4x2 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThan(double lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThanOrEqual(double4x2 lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThanOrEqual(double4x2 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThanOrEqual(double lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x2 op_Implicit(float4x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x2 op_Implicit(int4x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x2 op_Implicit(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x2 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x2 op_Implicit(uint4x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x2 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x2 op_Implicit(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Increment(double4x2 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Inequality(double4x2 lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Inequality(double lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Inequality(double4x2 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThan(double4x2 lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThan(double lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThan(double4x2 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThanOrEqual(double4x2 lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThanOrEqual(double4x2 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThanOrEqual(double lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Modulus(double lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Modulus(double4x2 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Modulus(double4x2 lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Multiply(double lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Multiply(double4x2 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Multiply(double4x2 lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Subtraction(double lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Subtraction(double4x2 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_Subtraction(double4x2 lhs, double4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x2 op_UnaryNegation(double4x2 val) { }

	[CallerCount(Count = 0)]
	public static double4x2 op_UnaryPlus(double4x2 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 34)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 34)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

