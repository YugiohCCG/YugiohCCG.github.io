namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct uint3x2 : IEquatable<uint3x2>, IFormattable
{
	public static readonly uint3x2 zero; //Field offset: 0x0
	public uint3 c0; //Field offset: 0x0
	public uint3 c1; //Field offset: 0xC

	public uint3 Item
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 12
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public uint3x2(uint3 c0, uint3 c1) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint3x2(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint3x2(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public uint3x2(bool3x2 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint3x2(int v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint3x2(int3x2 v) { }

	[CalledBy(Type = typeof(uint3x2), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(uint3x2))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint3x2(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public uint3x2(float3x2 v) { }

	[CalledBy(Type = typeof(uint3x2), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(uint3x2))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint3x2(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public uint3x2(double3x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint3 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x2 op_Addition(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x2 op_Addition(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x2 op_Addition(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x2 op_BitwiseAnd(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x2 op_BitwiseAnd(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x2 op_BitwiseAnd(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x2 op_BitwiseOr(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x2 op_BitwiseOr(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x2 op_BitwiseOr(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x2 op_Decrement(uint3x2 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x2 op_Division(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x2 op_Division(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x2 op_Division(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x2 op_Equality(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x2 op_Equality(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x2 op_Equality(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x2 op_ExclusiveOr(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x2 op_ExclusiveOr(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x2 op_ExclusiveOr(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x2 op_Explicit(int3x2 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint3x2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	public static uint3x2 op_Explicit(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x2 op_Explicit(float3x2 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint3x2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	public static uint3x2 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x2 op_Explicit(int v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x2 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x2 op_Explicit(bool3x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x2 op_Explicit(double3x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x2 op_GreaterThan(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x2 op_GreaterThan(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x2 op_GreaterThan(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x2 op_GreaterThanOrEqual(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x2 op_GreaterThanOrEqual(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x2 op_GreaterThanOrEqual(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x2 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x2 op_Increment(uint3x2 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x2 op_Inequality(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x2 op_Inequality(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x2 op_Inequality(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x2 op_LeftShift(uint3x2 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x2 op_LessThan(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x2 op_LessThan(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x2 op_LessThan(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x2 op_LessThanOrEqual(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x2 op_LessThanOrEqual(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x2 op_LessThanOrEqual(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x2 op_Modulus(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x2 op_Modulus(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x2 op_Modulus(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x2 op_Multiply(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x2 op_Multiply(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x2 op_Multiply(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x2 op_OnesComplement(uint3x2 val) { }

	[CallerCount(Count = 0)]
	public static uint3x2 op_RightShift(uint3x2 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x2 op_Subtraction(uint lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x2 op_Subtraction(uint3x2 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x2 op_Subtraction(uint3x2 lhs, uint3x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x2 op_UnaryNegation(uint3x2 val) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x2 op_UnaryPlus(uint3x2 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 26)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 26)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

