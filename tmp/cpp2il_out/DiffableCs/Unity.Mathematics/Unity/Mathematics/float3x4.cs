namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct float3x4 : IEquatable<float3x4>, IFormattable
{
	public static readonly float3x4 zero; //Field offset: 0x0
	public float3 c0; //Field offset: 0x0
	public float3 c1; //Field offset: 0xC
	public float3 c2; //Field offset: 0x18
	public float3 c3; //Field offset: 0x24

	public float3 Item
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 12
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float3x4(float3 c0, float3 c1, float3 c2, float3 c3) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float3x4(double v) { }

	[CalledBy(Type = typeof(float3x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint3x4)}, ReturnType = typeof(float3x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float3x4(uint3x4 v) { }

	[CalledBy(Type = typeof(float3x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(float3x4))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public float3x4(uint v) { }

	[CallerCount(Count = 0)]
	public float3x4(int3x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public float3x4(double3x4 v) { }

	[CalledBy(Type = typeof(float3x4), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool3x4)}, ReturnType = typeof(float3x4))]
	[CallerCount(Count = 1)]
	public float3x4(bool3x4 v) { }

	[CallerCount(Count = 0)]
	public float3x4(bool v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float3x4(float v) { }

	[CallerCount(Count = 0)]
	public float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public float3x4(int v) { }

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
	public override bool Equals(float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float3 get_Item(int index) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Addition(float3x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Addition(float lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Addition(float3x4 lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Decrement(float3x4 val) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Division(float3x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Division(float3x4 lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Division(float lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Equality(float3x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Equality(float3x4 lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Equality(float lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float3x4 op_Explicit(double v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float3x4 op_Explicit(bool v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool3x4)}, ReturnType = typeof(void))]
	public static float3x4 op_Explicit(bool3x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float3x4 op_Explicit(double3x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThan(float3x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThan(float lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThan(float3x4 lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThanOrEqual(float3x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThanOrEqual(float3x4 lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_GreaterThanOrEqual(float lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	public static float3x4 op_Implicit(uint v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float3x4 op_Implicit(int3x4 v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float3x4 op_Implicit(float v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float3x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint3x4)}, ReturnType = typeof(void))]
	public static float3x4 op_Implicit(uint3x4 v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static float3x4 op_Implicit(int v) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Increment(float3x4 val) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Inequality(float3x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Inequality(float3x4 lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_Inequality(float lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThan(float3x4 lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThan(float lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThan(float3x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThanOrEqual(float3x4 lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThanOrEqual(float3x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool3x4 op_LessThanOrEqual(float lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	public static float3x4 op_Modulus(float lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	public static float3x4 op_Modulus(float3x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	public static float3x4 op_Modulus(float3x4 lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Multiply(float lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Multiply(float3x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Multiply(float3x4 lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Subtraction(float lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Subtraction(float3x4 lhs, float rhs) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_Subtraction(float3x4 lhs, float3x4 rhs) { }

	[CallerCount(Count = 0)]
	public static float3x4 op_UnaryNegation(float3x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 205)]
	[ContainsUnimplementedInstructions]
	public static float3x4 op_UnaryPlus(float3x4 val) { }

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

