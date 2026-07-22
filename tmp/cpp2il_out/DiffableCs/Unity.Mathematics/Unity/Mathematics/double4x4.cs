namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct double4x4 : IEquatable<double4x4>, IFormattable
{
	public static readonly double4x4 identity; //Field offset: 0x0
	public static readonly double4x4 zero; //Field offset: 0x80
	public double4 c0; //Field offset: 0x0
	public double4 c1; //Field offset: 0x20
	public double4 c2; //Field offset: 0x40
	public double4 c3; //Field offset: 0x60

	public double4 Item
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	private static double4x4() { }

	[CallerCount(Count = 0)]
	public double4x4(float4x4 v) { }

	[CallerCount(Count = 0)]
	public double4x4(float v) { }

	[CalledBy(Type = typeof(double4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint4x4)}, ReturnType = typeof(double4x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public double4x4(uint4x4 v) { }

	[CalledBy(Type = typeof(double4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(double4x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public double4x4(uint v) { }

	[CalledBy(Type = typeof(double4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int4x4)}, ReturnType = typeof(double4x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public double4x4(int4x4 v) { }

	[CallerCount(Count = 0)]
	public double4x4(double4 c0, double4 c1, double4 c2, double4 c3) { }

	[CalledBy(Type = typeof(math), Member = "double4x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x4)}, ReturnType = typeof(double4x4))]
	[CalledBy(Type = typeof(double4x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x4)}, ReturnType = typeof(double4x4))]
	[CallerCount(Count = 2)]
	public double4x4(bool4x4 v) { }

	[CalledBy(Type = typeof(double4x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(double4x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public double4x4(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double4x4(double v) { }

	[CallerCount(Count = 0)]
	public double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double4x4(int v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double4x4), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4x4)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object o) { }

	[CalledBy(Type = typeof(double4x4), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 132)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(double4x4 rhs) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public double4 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4x4)}, ReturnType = typeof(uint))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Addition(double lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Addition(double4x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Addition(double4x4 lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Decrement(double4x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Division(double4x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Division(double4x4 lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Division(double lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Equality(double lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Equality(double4x4 lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Equality(double4x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public static double4x4 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x4)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public static double4x4 op_Explicit(bool4x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThan(double lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThan(double4x4 lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThan(double4x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThanOrEqual(double lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThanOrEqual(double4x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThanOrEqual(double4x4 lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint4x4)}, ReturnType = typeof(void))]
	public static double4x4 op_Implicit(uint4x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x4 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x4 op_Implicit(float4x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x4 op_Implicit(double v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	public static double4x4 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int4x4)}, ReturnType = typeof(void))]
	public static double4x4 op_Implicit(int4x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static double4x4 op_Implicit(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Increment(double4x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Inequality(double lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Inequality(double4x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_Inequality(double4x4 lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThan(double lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThan(double4x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThan(double4x4 lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThanOrEqual(double lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThanOrEqual(double4x4 lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThanOrEqual(double4x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Modulus(double4x4 lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Modulus(double lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Modulus(double4x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Multiply(double lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Multiply(double4x4 lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Multiply(double4x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Subtraction(double lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Subtraction(double4x4 lhs, double rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_Subtraction(double4x4 lhs, double4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static double4x4 op_UnaryNegation(double4x4 val) { }

	[CallerCount(Count = 0)]
	public static double4x4 op_UnaryPlus(double4x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 66)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 66)]
	public virtual string ToString() { }

}

