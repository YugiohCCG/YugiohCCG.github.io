namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct uint4x3 : IEquatable<uint4x3>, IFormattable
{
	public static readonly uint4x3 zero; //Field offset: 0x0
	public uint4 c0; //Field offset: 0x0
	public uint4 c1; //Field offset: 0x10
	public uint4 c2; //Field offset: 0x20

	public uint4 Item
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public uint4x3(uint4 c0, uint4 c1, uint4 c2) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x3(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x3(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public uint4x3(bool4x3 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x3(int v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x3(int4x3 v) { }

	[CalledBy(Type = typeof(uint4x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(uint4x3))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint4x3(float v) { }

	[CalledBy(Type = typeof(math), Member = "uint4x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x3)}, ReturnType = typeof(uint4x3))]
	[CalledBy(Type = typeof(uint4x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x3)}, ReturnType = typeof(uint4x3))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public uint4x3(float4x3 v) { }

	[CalledBy(Type = typeof(uint4x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(uint4x3))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint4x3(double v) { }

	[CalledBy(Type = typeof(math), Member = "uint4x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4x3)}, ReturnType = typeof(uint4x3))]
	[CalledBy(Type = typeof(uint4x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4x3)}, ReturnType = typeof(uint4x3))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public uint4x3(double4x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public uint4 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x3 op_Addition(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x3 op_Addition(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x3 op_Addition(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x3 op_BitwiseAnd(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x3 op_BitwiseAnd(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x3 op_BitwiseAnd(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x3 op_BitwiseOr(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x3 op_BitwiseOr(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x3 op_BitwiseOr(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	public static uint4x3 op_Decrement(uint4x3 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x3 op_Division(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x3 op_Division(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x3 op_Division(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x3 op_Equality(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x3 op_Equality(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x3 op_Equality(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x3 op_ExclusiveOr(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x3 op_ExclusiveOr(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x3 op_ExclusiveOr(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x3 op_Explicit(int4x3 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint4x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	public static uint4x3 op_Explicit(float v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint4x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x3)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public static uint4x3 op_Explicit(float4x3 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint4x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	public static uint4x3 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x3 op_Explicit(int v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x3 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x3 op_Explicit(bool4x3 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint4x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4x3)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public static uint4x3 op_Explicit(double4x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThan(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThan(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThan(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThanOrEqual(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThanOrEqual(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThanOrEqual(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x3 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x3 op_Increment(uint4x3 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x3 op_Inequality(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x3 op_Inequality(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x3 op_Inequality(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x3 op_LeftShift(uint4x3 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThan(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThan(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThan(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThanOrEqual(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThanOrEqual(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThanOrEqual(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x3 op_Modulus(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x3 op_Modulus(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x3 op_Modulus(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x3 op_Multiply(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x3 op_Multiply(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x3 op_Multiply(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x3 op_OnesComplement(uint4x3 val) { }

	[CallerCount(Count = 0)]
	public static uint4x3 op_RightShift(uint4x3 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x3 op_Subtraction(uint lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x3 op_Subtraction(uint4x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x3 op_Subtraction(uint4x3 lhs, uint4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x3 op_UnaryNegation(uint4x3 val) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x3 op_UnaryPlus(uint4x3 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 50)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 50)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

