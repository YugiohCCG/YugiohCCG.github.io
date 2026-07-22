namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct uint2x2 : IEquatable<uint2x2>, IFormattable
{
	public static readonly uint2x2 identity; //Field offset: 0x0
	public static readonly uint2x2 zero; //Field offset: 0x10
	public uint2 c0; //Field offset: 0x0
	public uint2 c1; //Field offset: 0x8

	public uint2 Item
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	private static uint2x2() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public uint2x2(double2x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public uint2x2(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public uint2x2(float2x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public uint2x2(float v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint2x2(int2x2 v) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public uint2x2(uint2 c0, uint2 c1) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public uint2x2(bool2x2 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint2x2(bool v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint2x2(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint2x2(uint m00, uint m01, uint m10, uint m11) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint2x2(int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public uint2 get_Item(int index) { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Addition(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Addition(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Addition(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_BitwiseAnd(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_BitwiseAnd(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_BitwiseAnd(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_BitwiseOr(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_BitwiseOr(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_BitwiseOr(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Decrement(uint2x2 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint2x2 op_Division(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint2x2 op_Division(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint2x2 op_Division(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool2x2 op_Equality(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool2x2 op_Equality(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool2x2 op_Equality(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_ExclusiveOr(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_ExclusiveOr(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_ExclusiveOr(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint2x2 op_Explicit(float2x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint2x2 op_Explicit(double2x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint2x2 op_Explicit(float v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Explicit(int2x2 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Explicit(int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint2x2 op_Explicit(bool2x2 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint2x2 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_GreaterThan(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_GreaterThan(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_GreaterThan(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_GreaterThanOrEqual(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_GreaterThanOrEqual(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_GreaterThanOrEqual(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Increment(uint2x2 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool2x2 op_Inequality(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool2x2 op_Inequality(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool2x2 op_Inequality(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_LeftShift(uint2x2 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_LessThan(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_LessThan(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_LessThan(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_LessThanOrEqual(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_LessThanOrEqual(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_LessThanOrEqual(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint2x2 op_Modulus(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint2x2 op_Modulus(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint2x2 op_Modulus(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Multiply(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Multiply(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Multiply(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_OnesComplement(uint2x2 val) { }

	[CallerCount(Count = 0)]
	public static uint2x2 op_RightShift(uint2x2 x, int n) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Subtraction(uint lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Subtraction(uint2x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_Subtraction(uint2x2 lhs, uint2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_UnaryNegation(uint2x2 val) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x2 op_UnaryPlus(uint2x2 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

