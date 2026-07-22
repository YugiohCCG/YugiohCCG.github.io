namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct uint4x2 : IEquatable<uint4x2>, IFormattable
{
	public static readonly uint4x2 zero; //Field offset: 0x0
	public uint4 c0; //Field offset: 0x0
	public uint4 c1; //Field offset: 0x10

	public uint4 Item
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public uint4x2(uint4 c0, uint4 c1) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x2(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x2(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public uint4x2(bool4x2 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x2(int v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x2(int4x2 v) { }

	[CalledBy(Type = typeof(uint4x2), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(uint4x2))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint4x2(float v) { }

	[CalledBy(Type = typeof(uint4x2), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x2)}, ReturnType = typeof(uint4x2))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint4x2(float4x2 v) { }

	[CalledBy(Type = typeof(uint4x2), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(uint4x2))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint4x2(double v) { }

	[CalledBy(Type = typeof(uint4x2), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4x2)}, ReturnType = typeof(uint4x2))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint4x2(double4x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public uint4 get_Item(int index) { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x2 op_Addition(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x2 op_Addition(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x2 op_Addition(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x2 op_BitwiseAnd(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x2 op_BitwiseAnd(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x2 op_BitwiseAnd(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x2 op_BitwiseOr(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x2 op_BitwiseOr(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x2 op_BitwiseOr(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	public static uint4x2 op_Decrement(uint4x2 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x2 op_Division(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x2 op_Division(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x2 op_Division(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x2 op_Equality(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x2 op_Equality(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x2 op_Equality(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x2 op_ExclusiveOr(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x2 op_ExclusiveOr(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x2 op_ExclusiveOr(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x2 op_Explicit(int4x2 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint4x2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	public static uint4x2 op_Explicit(float v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint4x2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x2)}, ReturnType = typeof(void))]
	public static uint4x2 op_Explicit(float4x2 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint4x2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	public static uint4x2 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x2 op_Explicit(int v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x2 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x2 op_Explicit(bool4x2 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint4x2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4x2)}, ReturnType = typeof(void))]
	public static uint4x2 op_Explicit(double4x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThan(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThan(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThan(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThanOrEqual(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThanOrEqual(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThanOrEqual(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x2 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x2 op_Increment(uint4x2 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x2 op_Inequality(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x2 op_Inequality(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x2 op_Inequality(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x2 op_LeftShift(uint4x2 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThan(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThan(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThan(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThanOrEqual(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThanOrEqual(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThanOrEqual(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x2 op_Modulus(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x2 op_Modulus(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x2 op_Modulus(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x2 op_Multiply(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x2 op_Multiply(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x2 op_Multiply(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x2 op_OnesComplement(uint4x2 val) { }

	[CallerCount(Count = 0)]
	public static uint4x2 op_RightShift(uint4x2 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x2 op_Subtraction(uint lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x2 op_Subtraction(uint4x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x2 op_Subtraction(uint4x2 lhs, uint4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x2 op_UnaryNegation(uint4x2 val) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x2 op_UnaryPlus(uint4x2 val) { }

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

