namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct float2x2 : IEquatable<float2x2>, IFormattable
{
	public static readonly float2x2 identity; //Field offset: 0x0
	public static readonly float2x2 zero; //Field offset: 0x10
	public float2 c0; //Field offset: 0x0
	public float2 c1; //Field offset: 0x8

	public float2 Item
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	private static float2x2() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public float2x2(double2x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float2x2(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float2x2(uint2x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float2x2(uint v) { }

	[CallerCount(Count = 0)]
	public float2x2(int2x2 v) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public float2x2(float2 c0, float2 c1) { }

	[CallerCount(Count = 0)]
	public float2x2(bool2x2 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float2x2(bool v) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public float2x2(float v) { }

	[CallerCount(Count = 0)]
	public float2x2(float m00, float m01, float m10, float m11) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float2x2(int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float2 get_Item(int index) { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x2 op_Addition(float2x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float2x2 op_Addition(float2x2 lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x2 op_Addition(float lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	public static float2x2 op_Decrement(float2x2 val) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float2x2 op_Division(float lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x2 op_Division(float2x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float2x2 op_Division(float2x2 lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_Equality(float2x2 lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_Equality(float2x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_Equality(float lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x2 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x2 op_Explicit(double2x2 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float2x2 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float2x2 op_Explicit(bool2x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_GreaterThan(float2x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_GreaterThan(float2x2 lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_GreaterThan(float lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_GreaterThanOrEqual(float2x2 lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_GreaterThanOrEqual(float2x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_GreaterThanOrEqual(float lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x2 op_Implicit(uint2x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x2 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float2x2 op_Implicit(int2x2 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x2 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float2x2 op_Implicit(float v) { }

	[CallerCount(Count = 0)]
	public static float2x2 op_Increment(float2x2 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_Inequality(float lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_Inequality(float2x2 lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_Inequality(float2x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_LessThan(float2x2 lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_LessThan(float lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_LessThan(float2x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_LessThanOrEqual(float2x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_LessThanOrEqual(float2x2 lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool2x2 op_LessThanOrEqual(float lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static float2x2 op_Modulus(float2x2 lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static float2x2 op_Modulus(float2x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static float2x2 op_Modulus(float lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x2 op_Multiply(float lhs, float2x2 rhs) { }

	[CallerCount(Count = 33)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x2 op_Multiply(float2x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float2x2 op_Multiply(float2x2 lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float2x2 op_Subtraction(float lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float2x2 op_Subtraction(float2x2 lhs, float2x2 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float2x2 op_Subtraction(float2x2 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float2x2 op_UnaryNegation(float2x2 val) { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	public static float2x2 op_UnaryPlus(float2x2 val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float2x2 Rotate(float angle) { }

	[CallerCount(Count = 0)]
	public static float2x2 Scale(float2 v) { }

	[CallerCount(Count = 0)]
	public static float2x2 Scale(float s) { }

	[CallerCount(Count = 0)]
	public static float2x2 Scale(float x, float y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

