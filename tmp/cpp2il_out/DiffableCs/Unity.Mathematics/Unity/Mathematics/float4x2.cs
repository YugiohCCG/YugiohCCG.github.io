namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct float4x2 : IEquatable<float4x2>, IFormattable
{
	public static readonly float4x2 zero; //Field offset: 0x0
	public float4 c0; //Field offset: 0x0
	public float4 c1; //Field offset: 0x10

	public float4 Item
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public float4x2(float4 c0, float4 c1) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float4x2(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float4x2(uint4x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float4x2(uint v) { }

	[CallerCount(Count = 0)]
	public float4x2(int4x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public float4x2(double4x2 v) { }

	[CalledBy(Type = typeof(float4x2), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x2)}, ReturnType = typeof(float4x2))]
	[CallerCount(Count = 1)]
	public float4x2(bool4x2 v) { }

	[CallerCount(Count = 0)]
	public float4x2(bool v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float4x2(float v) { }

	[CallerCount(Count = 0)]
	public float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float4x2(int v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(float4x2 rhs) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public float4 get_Item(int index) { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x2 op_Addition(float4x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x2 op_Addition(float lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	public static float4x2 op_Addition(float4x2 lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x2 op_Decrement(float4x2 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x2 op_Division(float4x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float4x2 op_Division(float4x2 lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	public static float4x2 op_Division(float lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Equality(float4x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Equality(float4x2 lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Equality(float lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float4x2 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float4x2 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x2)}, ReturnType = typeof(void))]
	public static float4x2 op_Explicit(bool4x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float4x2 op_Explicit(double4x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThan(float4x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThan(float lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThan(float4x2 lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThanOrEqual(float4x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThanOrEqual(float4x2 lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_GreaterThanOrEqual(float lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float4x2 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float4x2 op_Implicit(int4x2 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float4x2 op_Implicit(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float4x2 op_Implicit(uint4x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float4x2 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x2 op_Increment(float4x2 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Inequality(float4x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Inequality(float4x2 lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_Inequality(float lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThan(float4x2 lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThan(float lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThan(float4x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThanOrEqual(float4x2 lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThanOrEqual(float4x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x2 op_LessThanOrEqual(float lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public static float4x2 op_Modulus(float lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public static float4x2 op_Modulus(float4x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public static float4x2 op_Modulus(float4x2 lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x2 op_Multiply(float lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x2 op_Multiply(float4x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float4x2 op_Multiply(float4x2 lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	public static float4x2 op_Subtraction(float lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x2 op_Subtraction(float4x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float4x2 op_Subtraction(float4x2 lhs, float4x2 rhs) { }

	[CallerCount(Count = 0)]
	public static float4x2 op_UnaryNegation(float4x2 val) { }

	[CallerCount(Count = 0)]
	public static float4x2 op_UnaryPlus(float4x2 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 34)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 34)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

