namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct float4x3 : IEquatable<float4x3>, IFormattable
{
	public static readonly float4x3 zero; //Field offset: 0x0
	public float4 c0; //Field offset: 0x0
	public float4 c1; //Field offset: 0x10
	public float4 c2; //Field offset: 0x20

	public float4 Item
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public float4x3(float4 c0, float4 c1, float4 c2) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float4x3(double v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float4x3(uint4x3 v) { }

	[CalledBy(Type = typeof(float4x3), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(float4x3))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float4x3(uint v) { }

	[CallerCount(Count = 0)]
	public float4x3(int4x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public float4x3(double4x3 v) { }

	[CalledBy(Type = typeof(math), Member = "float4x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x3)}, ReturnType = typeof(float4x3))]
	[CalledBy(Type = typeof(float4x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x3)}, ReturnType = typeof(float4x3))]
	[CallerCount(Count = 2)]
	public float4x3(bool4x3 v) { }

	[CallerCount(Count = 0)]
	public float4x3(bool v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float4x3(float v) { }

	[CallerCount(Count = 0)]
	public float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float4x3(int v) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 100)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(float4x3 rhs) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public float4 get_Item(int index) { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x3 op_Addition(float4x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x3 op_Addition(float lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	public static float4x3 op_Addition(float4x3 lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x3 op_Decrement(float4x3 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x3 op_Division(float4x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float4x3 op_Division(float4x3 lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	public static float4x3 op_Division(float lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_Equality(float4x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_Equality(float4x3 lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_Equality(float lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float4x3 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float4x3 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool4x3)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public static float4x3 op_Explicit(bool4x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float4x3 op_Explicit(double4x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThan(float4x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThan(float lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThan(float4x3 lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThanOrEqual(float4x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThanOrEqual(float4x3 lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_GreaterThanOrEqual(float lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float4x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	public static float4x3 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float4x3 op_Implicit(int4x3 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float4x3 op_Implicit(float v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float4x3 op_Implicit(uint4x3 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float4x3 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x3 op_Increment(float4x3 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_Inequality(float4x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_Inequality(float4x3 lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_Inequality(float lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThan(float4x3 lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThan(float lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThan(float4x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThanOrEqual(float4x3 lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThanOrEqual(float4x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool4x3 op_LessThanOrEqual(float lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	public static float4x3 op_Modulus(float lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	public static float4x3 op_Modulus(float4x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	public static float4x3 op_Modulus(float4x3 lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x3 op_Multiply(float lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x3 op_Multiply(float4x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float4x3 op_Multiply(float4x3 lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	public static float4x3 op_Subtraction(float lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static float4x3 op_Subtraction(float4x3 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float4x3 op_Subtraction(float4x3 lhs, float4x3 rhs) { }

	[CallerCount(Count = 0)]
	public static float4x3 op_UnaryNegation(float4x3 val) { }

	[CallerCount(Count = 0)]
	public static float4x3 op_UnaryPlus(float4x3 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 50)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 50)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

