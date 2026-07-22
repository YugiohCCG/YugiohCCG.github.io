namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct int3x4 : IEquatable<int3x4>, IFormattable
{
	public static readonly int3x4 zero; //Field offset: 0x0
	public int3 c0; //Field offset: 0x0
	public int3 c1; //Field offset: 0xC
	public int3 c2; //Field offset: 0x18
	public int3 c3; //Field offset: 0x24

	public int3 Item
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 12
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int3x4(int3 c0, int3 c1, int3 c2, int3 c3) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int3x4(int v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int3x4(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public int3x4(bool3x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int3x4(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int3x4(uint3x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public int3x4(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public int3x4(float3x4 v) { }

	[CallerCount(Count = 0)]
	public int3x4(double v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int3x4(double3x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int3 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int3x4 op_Addition(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int3x4 op_Addition(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int3x4 op_Addition(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int3x4 op_BitwiseAnd(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_BitwiseAnd(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_BitwiseAnd(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_BitwiseOr(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int3x4 op_BitwiseOr(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_BitwiseOr(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int3x4 op_Decrement(int3x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int3x4 op_Division(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int3x4 op_Division(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int3x4 op_Division(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x4 op_Equality(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x4 op_Equality(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x4 op_Equality(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_ExclusiveOr(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int3x4 op_ExclusiveOr(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_ExclusiveOr(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_Explicit(uint3x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_Explicit(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_Explicit(float3x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int3x4 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int3x4 op_Explicit(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int3x4 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_Explicit(bool3x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_Explicit(double3x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThan(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThan(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThan(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThanOrEqual(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThanOrEqual(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThanOrEqual(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int3x4 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int3x4 op_Increment(int3x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x4 op_Inequality(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x4 op_Inequality(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x4 op_Inequality(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_LeftShift(int3x4 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThan(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThan(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThan(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThanOrEqual(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThanOrEqual(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThanOrEqual(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int3x4 op_Modulus(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int3x4 op_Modulus(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int3x4 op_Modulus(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int3x4 op_Multiply(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int3x4 op_Multiply(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int3x4 op_Multiply(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_OnesComplement(int3x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int3x4 op_RightShift(int3x4 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int3x4 op_Subtraction(int lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int3x4 op_Subtraction(int3x4 lhs, int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static int3x4 op_Subtraction(int3x4 lhs, int3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int3x4 op_UnaryNegation(int3x4 val) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int3x4 op_UnaryPlus(int3x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 50)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 50)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

