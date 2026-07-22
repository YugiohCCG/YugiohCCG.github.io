namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct double4x3 : IEquatable<double4x3>, IFormattable
{
	public static readonly double4x3 zero; //Field offset: 0x0
	public double4 c0; //Field offset: 0x0
	public double4 c1; //Field offset: 0x20
	public double4 c2; //Field offset: 0x40

	public double4 Item
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	public double4x3(double4 c0, double4 c1, double4 c2) { }

	[CallerCount(Count = 0)]
	public double4x3(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double4x3(uint4x3 v) { }

	[CalledBy(Type = typeof(double4x3), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(double4x3))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public double4x3(uint v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double4x3(int4x3 v) { }

	[CallerCount(Count = 0)]
	public double4x3(float4x3 v) { }

	[CalledBy(Type = typeof(math), Member = "double4x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x3)}, ReturnType = typeof(double4x3))]
	[CalledBy(Type = typeof(double4x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x3)}, ReturnType = typeof(double4x3))]
	[CallerCount(Count = 2)]
	public double4x3(bool4x3 v) { }

	[CalledBy(Type = typeof(double4x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(double4x3))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public double4x3(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public double4x3(double v) { }

	[CallerCount(Count = 0)]
	public double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double4x3(int v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double4x3), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4x3)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object o) { }

	[CalledBy(Type = typeof(double4x3), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 100)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(double4x3 rhs) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public double4 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4x3)}, ReturnType = typeof(uint))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Addition(double4x3 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Addition(double lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Addition(double4x3 lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Decrement(double4x3 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Division(double4x3 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Division(double4x3 lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Division(double lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_Equality(double4x3 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_Equality(double4x3 lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_Equality(double lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double4x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public static double4x3 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double4x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x3)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public static double4x3 op_Explicit(bool4x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThan(double4x3 lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThan(double4x3 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThan(double lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThanOrEqual(double4x3 lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThanOrEqual(double4x3 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThanOrEqual(double lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x3 op_Implicit(float4x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x3 op_Implicit(int4x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x3 op_Implicit(double v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double4x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	public static double4x3 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x3 op_Implicit(uint4x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x3 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x3 op_Implicit(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Increment(double4x3 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_Inequality(double4x3 lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_Inequality(double lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_Inequality(double4x3 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThan(double4x3 lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThan(double lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThan(double4x3 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThanOrEqual(double4x3 lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThanOrEqual(double4x3 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThanOrEqual(double lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Modulus(double lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Modulus(double4x3 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Modulus(double4x3 lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Multiply(double lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Multiply(double4x3 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Multiply(double4x3 lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Subtraction(double lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Subtraction(double4x3 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_Subtraction(double4x3 lhs, double4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x3 op_UnaryNegation(double4x3 val) { }

	[CallerCount(Count = 0)]
	public static double4x3 op_UnaryPlus(double4x3 val) { }

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

