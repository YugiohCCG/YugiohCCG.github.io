namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct double2x4 : IEquatable<double2x4>, IFormattable
{
	public static readonly double2x4 zero; //Field offset: 0x0
	public double2 c0; //Field offset: 0x0
	public double2 c1; //Field offset: 0x10
	public double2 c2; //Field offset: 0x20
	public double2 c3; //Field offset: 0x30

	public double2 Item
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public double2x4(double2 c0, double2 c1, double2 c2, double2 c3) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public double2x4(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double2x4(uint2x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double2x4(uint v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double2x4(int2x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public double2x4(float2x4 v) { }

	[CalledBy(Type = typeof(double2x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool2x4)}, ReturnType = typeof(double2x4))]
	[CallerCount(Count = 1)]
	public double2x4(bool2x4 v) { }

	[CallerCount(Count = 0)]
	public double2x4(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public double2x4(double v) { }

	[CallerCount(Count = 0)]
	public double2x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public double2x4(int v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(double2x4 rhs) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public double2 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double2x4)}, ReturnType = typeof(uint))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Addition(double2x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Addition(double lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Addition(double2x4 lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Decrement(double2x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Division(double2x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Division(double2x4 lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Division(double lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_Equality(double2x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_Equality(double2x4 lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_Equality(double lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static double2x4 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double2x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool2x4)}, ReturnType = typeof(void))]
	public static double2x4 op_Explicit(bool2x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThan(double2x4 lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThan(double2x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThan(double lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThanOrEqual(double2x4 lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThanOrEqual(double2x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThanOrEqual(double lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static double2x4 op_Implicit(float2x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double2x4 op_Implicit(int2x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double2x4 op_Implicit(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double2x4 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double2x4 op_Implicit(uint2x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double2x4 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double2x4 op_Implicit(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Increment(double2x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_Inequality(double2x4 lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_Inequality(double lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_Inequality(double2x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThan(double2x4 lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThan(double lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThan(double2x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThanOrEqual(double2x4 lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThanOrEqual(double2x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThanOrEqual(double lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public static double2x4 op_Modulus(double lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public static double2x4 op_Modulus(double2x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public static double2x4 op_Modulus(double2x4 lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Multiply(double lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Multiply(double2x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Multiply(double2x4 lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Subtraction(double lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Subtraction(double2x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double2x4 op_Subtraction(double2x4 lhs, double2x4 rhs) { }

	[CallerCount(Count = 0)]
	public static double2x4 op_UnaryNegation(double2x4 val) { }

	[CallerCount(Count = 0)]
	public static double2x4 op_UnaryPlus(double2x4 val) { }

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

