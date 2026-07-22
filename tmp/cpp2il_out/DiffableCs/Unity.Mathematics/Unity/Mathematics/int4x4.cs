namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct int4x4 : IEquatable<int4x4>, IFormattable
{
	public static readonly int4x4 identity; //Field offset: 0x0
	public static readonly int4x4 zero; //Field offset: 0x40
	public int4 c0; //Field offset: 0x0
	public int4 c1; //Field offset: 0x10
	public int4 c2; //Field offset: 0x20
	public int4 c3; //Field offset: 0x30

	public int4 Item
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	private static int4x4() { }

	[CallerCount(Count = 0)]
	public int4x4(double4x4 v) { }

	[CallerCount(Count = 0)]
	public int4x4(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public int4x4(float4x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public int4x4(float v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int4x4(uint4x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int4x4(int4 c0, int4 c1, int4 c2, int4 c3) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 30)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public int4x4(bool4x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int4x4(bool v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int4x4(int v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int4x4(uint v) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 132)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int4 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int4x4)}, ReturnType = typeof(uint))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_Addition(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_Addition(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_Addition(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int4x4 op_BitwiseAnd(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int4x4 op_BitwiseAnd(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int4x4 op_BitwiseAnd(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int4x4 op_BitwiseOr(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int4x4 op_BitwiseOr(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int4x4 op_BitwiseOr(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_Decrement(int4x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_Division(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_Division(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_Division(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x4 op_Equality(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x4 op_Equality(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x4 op_Equality(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int4x4 op_ExclusiveOr(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int4x4 op_ExclusiveOr(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int4x4 op_ExclusiveOr(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int4x4 op_Explicit(float4x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int4x4 op_Explicit(double4x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int4x4 op_Explicit(float v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int4x4 op_Explicit(uint4x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int4x4 op_Explicit(uint v) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static int4x4 op_Explicit(bool4x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int4x4 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int4x4 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThan(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThan(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThan(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThanOrEqual(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThanOrEqual(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThanOrEqual(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int4x4 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int4x4 op_Increment(int4x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x4 op_Inequality(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x4 op_Inequality(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x4 op_Inequality(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int4x4 op_LeftShift(int4x4 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThan(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThan(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThan(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThanOrEqual(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThanOrEqual(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThanOrEqual(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_Modulus(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_Modulus(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_Modulus(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int4x4 op_Multiply(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int4x4 op_Multiply(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int4x4 op_Multiply(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int4x4 op_OnesComplement(int4x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_RightShift(int4x4 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_Subtraction(int lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_Subtraction(int4x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int4x4 op_Subtraction(int4x4 lhs, int4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int4x4 op_UnaryNegation(int4x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 276)]
	[DeduplicatedMethod]
	public static int4x4 op_UnaryPlus(int4x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 66)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 66)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

