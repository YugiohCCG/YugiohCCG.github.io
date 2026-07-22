namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct uint4x4 : IEquatable<uint4x4>, IFormattable
{
	public static readonly uint4x4 identity; //Field offset: 0x0
	public static readonly uint4x4 zero; //Field offset: 0x40
	public uint4 c0; //Field offset: 0x0
	public uint4 c1; //Field offset: 0x10
	public uint4 c2; //Field offset: 0x20
	public uint4 c3; //Field offset: 0x30

	public uint4 Item
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	private static uint4x4() { }

	[CalledBy(Type = typeof(math), Member = "uint4x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4x4)}, ReturnType = typeof(uint4x4))]
	[CalledBy(Type = typeof(uint4x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4x4)}, ReturnType = typeof(uint4x4))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public uint4x4(double4x4 v) { }

	[CalledBy(Type = typeof(math), Member = "uint4x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(uint4x4))]
	[CalledBy(Type = typeof(uint4x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(uint4x4))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public uint4x4(double v) { }

	[CalledBy(Type = typeof(math), Member = "uint4x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(uint4x4))]
	[CalledBy(Type = typeof(uint4x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(uint4x4))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public uint4x4(float4x4 v) { }

	[CalledBy(Type = typeof(math), Member = "uint4x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(uint4x4))]
	[CalledBy(Type = typeof(uint4x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(uint4x4))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public uint4x4(float v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x4(int4x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 30)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public uint4x4(bool4x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x4(bool v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x4(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint4x4(int v) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 132)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public uint4 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x4 op_Addition(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x4 op_Addition(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x4 op_Addition(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x4 op_BitwiseAnd(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x4 op_BitwiseAnd(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x4 op_BitwiseAnd(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x4 op_BitwiseOr(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x4 op_BitwiseOr(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x4 op_BitwiseOr(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	public static uint4x4 op_Decrement(uint4x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x4 op_Division(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x4 op_Division(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x4 op_Division(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x4 op_Equality(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x4 op_Equality(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x4 op_Equality(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x4 op_ExclusiveOr(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x4 op_ExclusiveOr(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x4 op_ExclusiveOr(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public static uint4x4 op_Explicit(float4x4 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double4x4)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public static uint4x4 op_Explicit(double4x4 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public static uint4x4 op_Explicit(float v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x4 op_Explicit(int4x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x4 op_Explicit(int v) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static uint4x4 op_Explicit(bool4x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x4 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public static uint4x4 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThan(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThan(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThan(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThanOrEqual(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThanOrEqual(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_GreaterThanOrEqual(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x4 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x4 op_Increment(uint4x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x4 op_Inequality(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x4 op_Inequality(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool4x4 op_Inequality(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x4 op_LeftShift(uint4x4 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThan(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThan(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThan(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThanOrEqual(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThanOrEqual(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x4 op_LessThanOrEqual(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x4 op_Modulus(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x4 op_Modulus(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x4 op_Modulus(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x4 op_Multiply(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x4 op_Multiply(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint4x4 op_Multiply(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x4 op_OnesComplement(uint4x4 val) { }

	[CallerCount(Count = 0)]
	public static uint4x4 op_RightShift(uint4x4 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x4 op_Subtraction(uint lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x4 op_Subtraction(uint4x4 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint4x4 op_Subtraction(uint4x4 lhs, uint4x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint4x4 op_UnaryNegation(uint4x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 276)]
	[DeduplicatedMethod]
	public static uint4x4 op_UnaryPlus(uint4x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 66)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 66)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

