namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct uint3x3 : IEquatable<uint3x3>, IFormattable
{
	public static readonly uint3x3 identity; //Field offset: 0x0
	public static readonly uint3x3 zero; //Field offset: 0x24
	public uint3 c0; //Field offset: 0x0
	public uint3 c1; //Field offset: 0xC
	public uint3 c2; //Field offset: 0x18

	public uint3 Item
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 12
	}

	[CallerCount(Count = 0)]
	private static uint3x3() { }

	[CalledBy(Type = typeof(uint3x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double3x3)}, ReturnType = typeof(uint3x3))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint3x3(double3x3 v) { }

	[CalledBy(Type = typeof(uint3x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(uint3x3))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint3x3(double v) { }

	[CalledBy(Type = typeof(uint3x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3)}, ReturnType = typeof(uint3x3))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint3x3(float3x3 v) { }

	[CalledBy(Type = typeof(uint3x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(uint3x3))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public uint3x3(float v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint3x3(int3x3 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint3x3(uint3 c0, uint3 c1, uint3 c2) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public uint3x3(bool3x3 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint3x3(bool v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint3x3(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public uint3x3(int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(uint3x3 rhs) { }

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
	public static uint3x3 op_Addition(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x3 op_Addition(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x3 op_Addition(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x3 op_BitwiseAnd(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x3 op_BitwiseAnd(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x3 op_BitwiseAnd(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x3 op_BitwiseOr(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x3 op_BitwiseOr(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x3 op_BitwiseOr(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x3 op_Decrement(uint3x3 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x3 op_Division(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x3 op_Division(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x3 op_Division(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x3 op_Equality(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x3 op_Equality(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x3 op_Equality(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x3 op_ExclusiveOr(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x3 op_ExclusiveOr(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x3 op_ExclusiveOr(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3)}, ReturnType = typeof(void))]
	public static uint3x3 op_Explicit(float3x3 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double3x3)}, ReturnType = typeof(void))]
	public static uint3x3 op_Explicit(double3x3 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	public static uint3x3 op_Explicit(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x3 op_Explicit(int3x3 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x3 op_Explicit(int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x3 op_Explicit(bool3x3 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x3 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	public static uint3x3 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_GreaterThan(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_GreaterThan(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_GreaterThan(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_GreaterThanOrEqual(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_GreaterThanOrEqual(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_GreaterThanOrEqual(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x3 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x3 op_Increment(uint3x3 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x3 op_Inequality(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x3 op_Inequality(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool3x3 op_Inequality(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x3 op_LeftShift(uint3x3 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_LessThan(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_LessThan(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_LessThan(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_LessThanOrEqual(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_LessThanOrEqual(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x3 op_LessThanOrEqual(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x3 op_Modulus(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x3 op_Modulus(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x3 op_Modulus(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x3 op_Multiply(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x3 op_Multiply(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x3 op_Multiply(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x3 op_OnesComplement(uint3x3 val) { }

	[CallerCount(Count = 0)]
	public static uint3x3 op_RightShift(uint3x3 x, int n) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x3 op_Subtraction(uint lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x3 op_Subtraction(uint3x3 lhs, uint rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint3x3 op_Subtraction(uint3x3 lhs, uint3x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static uint3x3 op_UnaryNegation(uint3x3 val) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static uint3x3 op_UnaryPlus(uint3x3 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 38)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 38)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

