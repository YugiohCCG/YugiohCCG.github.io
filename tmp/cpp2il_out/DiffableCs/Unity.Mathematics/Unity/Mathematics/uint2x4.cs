namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct uint2x4 : IEquatable<uint2x4>, IFormattable
{
	public static readonly uint2x4 zero; //Field offset: 0x0
	public uint2 c0; //Field offset: 0x0
	public uint2 c1; //Field offset: 0x8
	public uint2 c2; //Field offset: 0x10
	public uint2 c3; //Field offset: 0x18

	public uint2 Item
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint2x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint2x4(uint v) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public uint2x4(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public uint2x4(bool2x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint2x4(int v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint2x4(int2x4 v) { }

	[CalledBy(Type = typeof(uint2x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(uint2x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint2x4(float v) { }

	[CalledBy(Type = typeof(uint2x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2x4)}, ReturnType = typeof(uint2x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint2x4(float2x4 v) { }

	[CalledBy(Type = typeof(uint2x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(uint2x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint2x4(double v) { }

	[CalledBy(Type = typeof(uint2x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double2x4)}, ReturnType = typeof(uint2x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint2x4(double2x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(uint2x4 rhs) { }

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
	public static uint2x4 op_Addition(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_Addition(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_Addition(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_BitwiseAnd(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_BitwiseAnd(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_BitwiseAnd(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_BitwiseOr(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_BitwiseOr(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_BitwiseOr(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_Decrement(uint2x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint2x4 op_Division(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint2x4 op_Division(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint2x4 op_Division(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool2x4 op_Equality(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool2x4 op_Equality(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool2x4 op_Equality(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_ExclusiveOr(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_ExclusiveOr(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_ExclusiveOr(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_Explicit(int2x4 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint2x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	public static uint2x4 op_Explicit(float v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint2x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2x4)}, ReturnType = typeof(void))]
	public static uint2x4 op_Explicit(float2x4 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint2x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	public static uint2x4 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_Explicit(int v) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static uint2x4 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint2x4 op_Explicit(bool2x4 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint2x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double2x4)}, ReturnType = typeof(void))]
	public static uint2x4 op_Explicit(double2x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThan(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThan(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThan(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThanOrEqual(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThanOrEqual(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThanOrEqual(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_Increment(uint2x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool2x4 op_Inequality(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool2x4 op_Inequality(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool2x4 op_Inequality(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_LeftShift(uint2x4 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThan(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThan(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThan(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThanOrEqual(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThanOrEqual(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThanOrEqual(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint2x4 op_Modulus(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint2x4 op_Modulus(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint2x4 op_Modulus(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_Multiply(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_Multiply(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_Multiply(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_OnesComplement(uint2x4 val) { }

	[CallerCount(Count = 0)]
	public static uint2x4 op_RightShift(uint2x4 x, int n) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_Subtraction(uint lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_Subtraction(uint2x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_Subtraction(uint2x4 lhs, uint2x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_UnaryNegation(uint2x4 val) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint2x4 op_UnaryPlus(uint2x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 34)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 34)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

