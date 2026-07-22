namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct float2x4 : IEquatable<float2x4>, IFormattable
{
	public static readonly float2x4 zero; //Field offset: 0x0
	public float2 c0; //Field offset: 0x0
	public float2 c1; //Field offset: 0x8
	public float2 c2; //Field offset: 0x10
	public float2 c3; //Field offset: 0x18

	public float2 Item
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	public float2x4(float2 c0, float2 c1, float2 c2, float2 c3) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float2x4(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float2x4(uint2x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float2x4(uint v) { }

	[CallerCount(Count = 0)]
	public float2x4(int2x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public float2x4(double2x4 v) { }

	[CalledBy(Type = typeof(float2x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool2x4)}, ReturnType = typeof(float2x4))]
	[CallerCount(Count = 1)]
	public float2x4(bool2x4 v) { }

	[CallerCount(Count = 0)]
	public float2x4(bool v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float2x4(float v) { }

	[CallerCount(Count = 0)]
	public float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float2x4(int v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(float2x4 rhs) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float2 get_Item(int index) { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float2x4 op_Addition(float2x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float2x4 op_Addition(float lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float2x4 op_Addition(float2x4 lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float2x4 op_Decrement(float2x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float2x4 op_Division(float2x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float2x4 op_Division(float2x4 lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float2x4 op_Division(float lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_Equality(float2x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_Equality(float2x4 lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_Equality(float lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x4 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float2x4 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float2x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool2x4)}, ReturnType = typeof(void))]
	public static float2x4 op_Explicit(bool2x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x4 op_Explicit(double2x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThan(float2x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThan(float lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThan(float2x4 lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThanOrEqual(float2x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThanOrEqual(float2x4 lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_GreaterThanOrEqual(float lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x4 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float2x4 op_Implicit(int2x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float2x4 op_Implicit(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x4 op_Implicit(uint2x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x4 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	public static float2x4 op_Increment(float2x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_Inequality(float2x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_Inequality(float2x4 lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_Inequality(float lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThan(float2x4 lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThan(float lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThan(float2x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThanOrEqual(float2x4 lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThanOrEqual(float2x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x4 op_LessThanOrEqual(float lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public static float2x4 op_Modulus(float lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public static float2x4 op_Modulus(float2x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public static float2x4 op_Modulus(float2x4 lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float2x4 op_Multiply(float lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float2x4 op_Multiply(float2x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float2x4 op_Multiply(float2x4 lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float2x4 op_Subtraction(float lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float2x4 op_Subtraction(float2x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float2x4 op_Subtraction(float2x4 lhs, float2x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float2x4 op_UnaryNegation(float2x4 val) { }

	[CallerCount(Count = 0)]
	public static float2x4 op_UnaryPlus(float2x4 val) { }

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

